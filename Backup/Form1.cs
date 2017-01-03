using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using RecordingJZ;
using Microsoft.DirectX.DirectSound;

namespace SentenceRecorder
{
    public partial class Form1 : Form
    {
        ArrayList ListOfSentences;
        bool bListOfSentencesOpened = false;
        bool bOutputDirSelected = false;



        JZRecorder _recorder;
        private WaveFormat _waveFormat;
        private MemoryStream _streamMemory;
        private Stream _streamWave;
        private FileStream _streamFile;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgOutputFolder.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                if (ListOfSentences != null)
                    ListOfSentences = null;
                ListOfSentences = new ArrayList();

                lblListOfSentences.Text = dlgFileOpen.FileName;
                bListOfSentencesOpened = true;

                string Line;

                FileStream s = new FileStream(dlgFileOpen.FileName , FileMode.Open);
                StreamReader r = new StreamReader(s, Encoding.Default);

                while ((Line = r.ReadLine()) != null)
                {
                    ListOfSentences.Add(Line);
                }

                r.Close();
                s.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dlgOutputFolder.ShowDialog() == DialogResult.OK)
            {
                lblOutputDirectory.Text = dlgOutputFolder.SelectedPath;
                bOutputDirSelected = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            _waveFormat = new WaveFormat(16000, 16, 1);
            _streamMemory = new MemoryStream();

            _recorder = new JZRecorder();
            _recorder.HaveData += new DataReadyEventHandler(_recorder_HaveData);
            _recorder.Start(); 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          if (_recorder != null)
            try
            {
                _recorder.Dispose();
            }
            finally
            {
                _recorder = null;
            }
                      
            if (_streamMemory.Length < 50000)
            {
                ClearStreams();                
                return;
            }            

            byte[] waveBuffer = new byte[16];
            _streamWave = WaveStream.CreateStream(_streamMemory, _waveFormat);
            waveBuffer = new byte[_streamWave.Length];
            _streamWave.Read(waveBuffer, 0, waveBuffer.Length);
            _streamFile = new FileStream(dlgOutputFolder.SelectedPath+@"001.wav", FileMode.Create);
            _streamFile.Write(waveBuffer, 0, waveBuffer.Length);

            ClearStreams();
           
        }

        private void ClearStreams()
        {
            if (_recorder != null)
                try
                {
                    _recorder.Dispose();
                }
                finally
                {
                    _recorder = null;
                }

            if (_streamWave != null)
                try
                {
                    _streamWave.Close();
                }
                finally
                {
                    _streamWave = null;
                }
            if (_streamFile != null)
                try
                {
                    _streamFile.Close();
                }
                finally
                {
                    _streamFile = null;
                }
            if (_streamMemory != null)
                try
                {
                    _streamMemory.Close();
                }
                finally
                {
                    _streamMemory = null;
                }
        }
    }
}