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
using System.Text.RegularExpressions;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.Xml;
using System.Xml.Serialization;

namespace SentenceRecorder
{    

    public partial class Form1 : Form
    {
        Hashtable ListOfSentences = new Hashtable();
        bool bListOfSentencesOpened = false;
        bool bOutputDirSelected = false;
        string strLastFileName;
        int selectedIndex;
        int nSentencesToRead;
        public int selectedDeviceId;
               

        JZRecorder[] _recorder;
        private WaveFormat _waveFormat;
        private MemoryStream[] _streamMemory;
        private Stream _streamWave;
        private FileStream _streamFile;
        //private int no_devices_in_use=0;

        private System.Media.SoundPlayer myPlayer;

        public Form1()
        {
            InitializeComponent();

            CaptureDevicesCollection devices = new CaptureDevicesCollection();
            foreach (DeviceInformation di in devices)
                checkedListBox1.Items.Add(di.Description);
            if (checkedListBox1.Items.Count > 1)
                checkedListBox1.SelectedIndex = 1;       
            else
                checkedListBox1.SelectedIndex = 0;

            _streamMemory = new MemoryStream[checkedListBox1.Items.Count];
            _recorder = new JZRecorder[checkedListBox1.Items.Count];
        }

        void _recorder_HaveData(object sender, EventArgs e)
        {
            int size = ((MyEventArgs)e).size;
            byte[] data = ((MyEventArgs)e).data;
            int rec_id = ((MyEventArgs)e).rec_id;
            _streamMemory[rec_id].Write(data, 0, size);
            _streamMemory[rec_id].Flush();
        }

        private void ClearStreams()
        {
            for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    if (_recorder[x] != null)
                        try
                        {
                            _recorder[x].Dispose();
                        }
                        finally
                        {
                            _recorder[x] = null;
                        }
                }
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
            for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    if (_streamMemory[x] != null)
                        try
                        {
                            _streamMemory[x].Close();
                        }
                        finally
                        {
                            _streamMemory[x] = null;
                        }
                }
            }
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            if (dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                if (ListOfSentences.Count > 0)
                    ListOfSentences.Clear();
                nSentencesToRead = 0;

                lblListOfSentences.Text = dlgFileOpen.FileName;
                bListOfSentencesOpened = true;

                string Line;

                FileStream s = new FileStream(dlgFileOpen.FileName, FileMode.Open);
                StreamReader r = new StreamReader(s, Encoding.Default);                

                while ((Line = r.ReadLine()) != null)
                {
                    ListOfSentences.Add(nSentencesToRead , Line);                    
                    nSentencesToRead++;
                }                

                r.Close();
                s.Close();
            }
        }

        private void btnDirOpen_Click(object sender, EventArgs e)
        {
            if (dlgOutputFolder.ShowDialog() == DialogResult.OK)
            {
                lblOutputDirectory.Text = dlgOutputFolder.SelectedPath;
                bOutputDirSelected = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = Color.Red;
            Label1.Text = "....nahrávám....";
            Label1.Left = (pnlAdaptText.Size.Width - Label1.Size.Width) / 2;
            //btnSound.Enabled = false;
            //btnStart.Text = "Znovu nahrát";
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnNext.Enabled = false;            
            btnSound.Enabled = false;
            btnSkip.Enabled = false;
            btnFinishRecording.Enabled = false;
            btnStop.Focus();
            //btnCloseWindow.Enabled = false;
            pnlAdaptText.BackColor = Color.Red;

            ClearStreams();
            _waveFormat = new WaveFormat(16000, 16, 1);
            //no_devices_in_use = checkedListBox1.Items.Count;
            
            
            for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    _streamMemory[x] = new MemoryStream();
                    _recorder[x] = new JZRecorder(x);
                    //_recorder[x].selectedDeviceId = x;
                    _recorder[x].HaveData += new DataReadyEventHandler(_recorder_HaveData);
                    _recorder[x].Start(); 
                }
                 
            }

                
            
            



            
            
            //string a = _recorder.applicationDevice.ToString();
            
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    if (_recorder[x] != null)
                        try
                        {
                            _recorder[x].Dispose();
                        }
                        finally
                        {
                            _recorder[x] = null;
                        }
                }
            }



            Label1.ForeColor = Color.Black;
            Label1.Text = " pøeètìte vìtu:";
            Label1.Left = (pnlAdaptText.Size.Width - Label1.Size.Width) / 2;
            pnlAdaptText.BackColor = System.Drawing.SystemColors.Control;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnNext.Enabled = true;
            btnSkip.Enabled = true;
            btnFinishRecording.Enabled = true;                        

            /*if (_streamMemory.Length < 50000)
            {
                ClearStreams();
                btnNext.Enabled = false;              
                return;
            }*/

            btnNext.Enabled = true;              
            if (btnNext.Enabled)
                btnNext.Focus();

            SaveFiles();
            DrawSignal();
            ClearStreams();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richAdaptSentences.Text = "";
            myPlayer = new System.Media.SoundPlayer();
            ClearSignal();
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Vyberte pohlaví mluvèího!", "Není vybráno pohlaví mluvèího", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return ;
            }

            if (bListOfSentencesOpened == false)
            {
                MessageBox.Show("Vyberte seznam vìt pro ètení", "Není vybrán seznam vìt pro ètení", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return ;
            }

            if (bOutputDirSelected == false)
            {
                MessageBox.Show("Vyberte výstupní adresáø", "Není vybrán výstupní adresáø", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return ;
            }

            if (txtSpeakerName.Text == "")
            {
                MessageBox.Show("Zadejte jméno mluvèího", "Není zadáno jméno mluvèího", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return ;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vyberte zaøízení", "Není zadáno vybráno zaøízení", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            pnlAdaptText.Enabled=true;
            pnlStatus.Enabled=true;
            pnlButtons.Enabled=true;
            pnlOpen.Enabled=false;
            btnNext.Enabled = false;
            lblCount.Text = "0";            

            txtSpeakerName.Text = Regex.Replace(txtSpeakerName.Text, @"\s+", "", RegexOptions.None);            

            ShowNewWord();    
        }

        public void ShowNewWord()
        {
            Random RandomNumber = new Random();
            int index;
            if (ListOfSentences.Count > 0)
            {
                index =  RandomNumber.Next(0,nSentencesToRead );
                while (!ListOfSentences.ContainsKey(index))
                {
                    index = RandomNumber.Next(0, nSentencesToRead);
                }
                
                selectedIndex = index;

                
                btnSkip.Enabled = true;                
                btnNext.Enabled = false;              
                
                richAdaptSentences.Text = (string) ListOfSentences[index];

                btnStop.Enabled = false;
                btnSound.Enabled = false;
                ClearSignal();                
                
            }
            else
            {                
                richAdaptSentences.Text = "";
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnNext.Enabled = false;
                btnSkip.Enabled = false;
                btnSound.Enabled = false;                
            }
        }

      

        public void ClearSignal()
        {
            Graphics sigGraphics = pnlSig.CreateGraphics();
            Brush brushWhite = new SolidBrush(Color.White);                      
            sigGraphics.FillRectangle(brushWhite, 0, 0, pnlSig.Width, pnlSig.Height);            
            sigGraphics.Dispose();
        }

        public void DrawSignal()
        {
            int vyskaobd;
            long meritkod;
            int meritkov;
            long filesize;
            int min;
            int max;
            long i, ii;

            short[] pole16;            

            FileInfo fileInfo = new FileInfo(strLastFileName+".wav");
            filesize=fileInfo.Length;
            pole16 = new short[filesize];

            FileStream inStream = File.OpenRead(strLastFileName + ".wav");
            // use a BinaryReader to read formatted data and dump it to the screen
            BinaryReader br = new BinaryReader(inStream);
            br.ReadBytes(44);

            for (i=0;i<(filesize-44)/2;i++)
                pole16[i] = br.ReadInt16 ();
            br.Close();


            Graphics sigGraphics = pnlSig.CreateGraphics();                
            Brush brushWhite = new SolidBrush(Color.White);
            
            Pen BlackPen = new Pen(Color.Black);
            //FormGraphics.DrawLine(BlackPen, FirstPoint, LastPoint);

            sigGraphics.FillRectangle(brushWhite, 0, 0, pnlSig.Width, pnlSig.Height);

            vyskaobd = pnlSig.Height;
            meritkod = (filesize / 2 / pnlSig.Width );  //pocet samplu na 1 pixel
            meritkov = (32768 / pnlSig.Height * 2);

            sigGraphics.DrawLine(BlackPen, 0, vyskaobd / 2, pnlSig.Width, vyskaobd / 2);
            
            //Form1->Image1->Canvas->MoveTo(0, vyskaobd / 2);
            max = min = 0;
            for (i = 0; i < pnlSig.Width; i++)
            {
                for (ii = i * meritkod; ii < (i + 1) * meritkod; ii++)
                {
                    if (pole16[ii] >= max)
                    {
                        max = pole16[ii];
                    }
                    if (pole16[ii] < min)
                    {
                        min = pole16[ii];
                    }
                }
                max = max / meritkov;
                min = min / meritkov;
                sigGraphics.DrawLine(BlackPen,i, vyskaobd / 2 - max,i, vyskaobd / 2 - min);
                max = 0;
                min = 0;
            }
            sigGraphics.Dispose();

        }

        public void SaveFiles()
        {
            StreamWriter ftxt;
            DateTime Now;
            //get first device




            int no = 0;
            string patt = "_" + selectedIndex.ToString() + "_";
            if (strLastFileName != null)
                if (Regex.IsMatch(strLastFileName,patt))
                {
                    File.Delete(strLastFileName+".wav");
                    File.Delete(strLastFileName+".txt");
                    File.Delete(strLastFileName+".xml");
                    
                    for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
                    {
                        if (checkedListBox1.GetItemChecked(x))
                        {
                            if (no > 0) File.Delete(strLastFileName+ "_D" + no.ToString() + ".wav");                            
                            no++;
                        }
                    }
                }


            string FileName = dlgOutputFolder.SelectedPath + "\\";
            if (radioButton1.Checked)
                FileName += "M_" + txtSpeakerName.Text + '_' + selectedIndex.ToString() + '_';
            else
                FileName += "F_" + txtSpeakerName.Text + '_' + selectedIndex.ToString() + '_';

            string strDate;
            Now = DateTime.Now; 
            strDate = Now.ToString();
            strDate = Regex.Replace(strDate, @"[\s+,\.,\:,\/]", "-");

            FileName += strDate;
            strLastFileName = FileName;

            Sentence newSentence = new Sentence();
            if (radioButton1.Checked)
                newSentence.bMale = true;
            else
                newSentence.bMale = false;
            newSentence.strCondition = cmbEnvironment.SelectedItem.ToString();
            //newSentence.strDevice = //checkedListBox1.SelectedItem.ToString();
            newSentence.strMark = txtMark.Text;
            newSentence.strTextForm = richAdaptSentences.Text;

            no = 0;
            for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
            {
                if (checkedListBox1.GetItemChecked(x))
                {
                    byte[] waveBuffer = new byte[16];
                    _streamWave = WaveStream.CreateStream(_streamMemory[x], _waveFormat);
                    waveBuffer = new byte[_streamWave.Length];
                    _streamWave.Read(waveBuffer, 0, waveBuffer.Length);
                    if (no == 0)
                    {
                        newSentence.strDevice = "BASE:=" + checkedListBox1.Items[x].ToString();
                        _streamFile = new FileStream(FileName + ".wav", FileMode.Create);
                    }
                    else
                    {
                        newSentence.strDevice = newSentence.strDevice + ";" + no.ToString() + ":=" + checkedListBox1.Items[x].ToString();
                        _streamFile = new FileStream(FileName + "_D" + no.ToString() + ".wav", FileMode.Create);
                    }
                    _streamFile.Write(waveBuffer, 0, waveBuffer.Length);
                    _streamFile.Close();
                    no++;
                }
            }
            btnSound.Enabled = true;

            ftxt = new StreamWriter(new FileStream(FileName + ".txt", FileMode.Create), Encoding.Default);
            ftxt.Write(richAdaptSentences.Text);
            ftxt.Close();

            XmlWriter w = XmlWriter.Create(FileName+".xml");
            XmlSerializer s = new XmlSerializer(typeof(Sentence ));
            s.Serialize(w, newSentence);
            w.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            string patt = "_" + selectedIndex.ToString() + "_";
            if (strLastFileName != null)
            {
                int no = 0;
                if (Regex.IsMatch(strLastFileName, patt))
                {
                    File.Delete(strLastFileName + ".wav");
                    File.Delete(strLastFileName + ".txt");
                    File.Delete(strLastFileName + ".xml");

                    for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
                    {
                        if (checkedListBox1.GetItemChecked(x))
                        {
                            if (no > 0) File.Delete(strLastFileName + "_D" + no.ToString() + ".wav");
                            no++;
                        }
                    }
                }
            }
         
            ListOfSentences.Remove(selectedIndex);            
            ClearSignal();
            ShowNewWord();                                    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ListOfSentences.Remove(selectedIndex);
            ShowNewWord();
            btnNext.Focus();
            lblCount.Text = Convert.ToString(Convert.ToInt16(lblCount.Text) + 1);
        }


        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            pnlAdaptText.Enabled = false;
            pnlButtons.Enabled = false;
            pnlOpen.Enabled = true;
            pnlStatus.Enabled = false;            
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (btnSound.Text == "Pøehrát")
            {
                btnSound.Text = "Zastavit";
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnNext.Enabled = false;
                btnSkip.Enabled = false;
                btnFinishRecording.Enabled = false;

                if (File.Exists(strLastFileName  + ".wav"))
                {
                    myPlayer.SoundLocation = strLastFileName  + ".wav";
                    myPlayer.PlayLooping();
                }
            }
            else
            {
                myPlayer.Stop();
                btnSound.Text = "Pøehrát";                
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                
                btnFinishRecording.Enabled = true;
                if (ListOfSentences.Count > 1)
                    btnSkip.Enabled = true;
                else
                    btnSkip.Enabled = false;

                string patt = "_" + selectedIndex.ToString() + "_";
                if (strLastFileName != null)
                    if (Regex.IsMatch(strLastFileName,patt))
                    {
                        btnNext.Enabled=true;
                    }
                
                
                
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Chcete opravdu ukonèit program?", "Ukonèení programu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                myPlayer.Stop();            
            }
            else
                e.Cancel = true;

            StreamWriter ftxt;
            ftxt = new StreamWriter(new FileStream(dlgFileOpen.FileName , FileMode.Create), Encoding.Default);
            foreach (int index in ListOfSentences.Keys)
            {
                ftxt.WriteLine(ListOfSentences[index]);
            }
            
            ftxt.Close();

        }

        private void richAdaptSentences_TextChanged(object sender, EventArgs e)
        {
            StreamWriter ftxt; 

            if (richAdaptSentences != null)
                if (richAdaptSentences.Text != "")
                {
                    ListOfSentences[selectedIndex] = richAdaptSentences.Text;                    
                }
            string patt = "_" + selectedIndex.ToString() + "_";
            if (strLastFileName != null)
                if (Regex.IsMatch(strLastFileName, patt))
                {
                    Sentence newSentence = new Sentence();
                    if (radioButton1.Checked)
                        newSentence.bMale = true;
                    else
                        newSentence.bMale = false;
                    newSentence.strCondition = cmbEnvironment.SelectedItem.ToString();
                    newSentence.strDevice = checkedListBox1.SelectedItem.ToString();
                    newSentence.strMark = txtMark.Text;
                    newSentence.strTextForm = richAdaptSentences.Text;                    

                    ftxt = new StreamWriter(new FileStream(strLastFileName + ".txt", FileMode.Create), Encoding.Default);
                    ftxt.Write(richAdaptSentences.Text);
                    ftxt.Close();

                    XmlWriter w = XmlWriter.Create(strLastFileName + ".xml");
                    XmlSerializer s = new XmlSerializer(typeof(Sentence));
                    s.Serialize(w, newSentence);
                    w.Close();                    
                }
        }

        private void pnlOpen_Paint(object sender, PaintEventArgs e)
        {
            cmbEnvironment.SelectedIndex = 0;
        }

        [XmlInclude(typeof(Sentence))]
        public class Sentence
        {            
            public string strTextForm;

            public string strUserName;
            public string strCondition;
            public string strMark;
            public string strDevice;
            public bool bMale;            
        }

        private void nápovìdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmHelp = new Form2();
            frmHelp.ShowDialog();
        }


    }    
}