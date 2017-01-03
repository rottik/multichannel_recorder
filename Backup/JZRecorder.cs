using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

namespace RecordingJZ
{
    public delegate void DataReadyEventHandler(object sender, EventArgs e);

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(byte[] data, int size)
        {
            this.data = data;
            this.size = size;
        }
        public byte[] data ;
        public int size;

    }
    
    public class JZRecorder : IDisposable

    {
        public event DataReadyEventHandler HaveData;
        public int NumberRecordNotifications = 0;
        public BufferPositionNotify[] PositionNotify;
         public AutoResetEvent NotificationEvent = null;
        public CaptureBuffer applicationBuffer = null;
        //public Guid CaptureDeviceGuid = Guid.Empty;
        public Capture applicationDevice = null;
        public Notify applicationNotify = null;
        private Thread NotifyThread = null;
        public int CaptureBufferSize = 0;
        public int NextCaptureOffset = 0;
        public WaveFormat InputFormat;
        public int NotifySize = 0;
        private bool Capturing = false;
        private int SampleCount = 0;
        
        protected virtual void OnHaveData(MyEventArgs e)
        {
                HaveData(this, e);
        }
        public JZRecorder()  
        {
            
            //m_DataReady = l_DataReady;
            CaptureBufferSize = 320000;
            NotifySize = 960;
            NumberRecordNotifications = CaptureBufferSize / NotifySize;
            PositionNotify = new BufferPositionNotify[NumberRecordNotifications];
            // Create DirectSound.Capture using the preferred capture device
            try
            {
                applicationDevice = new Capture(DSoundHelper.DefaultCaptureDevice);
                CaptureBufferDescription dscheckboxd = new CaptureBufferDescription();
                InputFormat.FormatTag = WaveFormatTag.Pcm;
                InputFormat.Channels = 1;
                InputFormat.SamplesPerSecond = 16000;
                InputFormat.BitsPerSample = 16;
                InputFormat.BlockAlign = (short)(InputFormat.Channels * (InputFormat.BitsPerSample / 8));
                InputFormat.AverageBytesPerSecond = InputFormat.SamplesPerSecond * InputFormat.BlockAlign;
                dscheckboxd.BufferBytes = CaptureBufferSize;
                
                dscheckboxd.Format = InputFormat; // Set the format during creation
                applicationBuffer = new CaptureBuffer(dscheckboxd, applicationDevice);

                if (null == applicationBuffer)
                    throw new NullReferenceException();
                
                // Create a thread to monitor the notify events
                if (null == NotifyThread)
                {
                    // Create a notification event, for when the sound stops playing
                    NotificationEvent = new AutoResetEvent(false);
                    NotifyThread = new Thread(new ThreadStart(WaitThread));
                    Capturing = true;
                    
                    NotifyThread.Start();
                    NotifyThread.Priority = ThreadPriority.Highest;
                    
                }


                // Setup the notification positions
                for (int i = 0; i < NumberRecordNotifications; i++)
                {
                    PositionNotify[i].Offset = (NotifySize * i) + NotifySize - 1;
                    PositionNotify[i].EventNotifyHandle = NotificationEvent.Handle;
                }

                applicationNotify = new Notify(applicationBuffer);

                // Tell DirectSound when to notify the app. The notification will come in the from 
                // of signaled events that are handled in the notify thread.
                applicationNotify.SetNotificationPositions(PositionNotify, NumberRecordNotifications);
                
            }
            catch { 
                
            }
        }
        public void Start()
        {
            applicationBuffer.Start(true);
        }
        ~JZRecorder()
		{
            
		}

        
        private void WaitThread()
        {
            while (Capturing)
            {
                //Sit here and wait for a message to arrive
                NotificationEvent.WaitOne(Timeout.Infinite, true);
                if(Capturing)
                    AnnounceCapturedData();
            }
        }
        void AnnounceCapturedData()
        {
            //-----------------------------------------------------------------------------
            // Name: RecordCapturedData()
            // Desc: Copies data from the capture buffer to the output buffer 
            //-----------------------------------------------------------------------------
            byte[] CaptureData = null;
            int ReadPos;
            int CapturePos;
            int LockSize;

            applicationBuffer.GetCurrentPosition(out CapturePos, out ReadPos);
            LockSize = ReadPos - NextCaptureOffset;
            if (LockSize < 0)
                LockSize += CaptureBufferSize;

            // Block align lock size so that we are always write on a boundary
            LockSize -= (LockSize % NotifySize);

            if (0 == LockSize)
                return;

            // Read the capture buffer.
            CaptureData = (byte[])applicationBuffer.Read(NextCaptureOffset, typeof(byte), LockFlag.None, LockSize);
            // Update the number of samples, in bytes, of the file so far.
            SampleCount += CaptureData.Length;

            // Move the capture offset along
            NextCaptureOffset += CaptureData.Length;
            NextCaptureOffset %= CaptureBufferSize; // Circular buffer
            MyEventArgs e=new MyEventArgs(CaptureData,CaptureData.Length);
            HaveData(this,e);
        }

        public void Dispose()
        {
            Capturing = false;
            NotificationEvent.Set();
            NotifyThread.Join();
            applicationBuffer.Stop();
            PositionNotify = null;
            NotifyThread=null;
            applicationBuffer.Dispose();
            
        }

        
    }
}
