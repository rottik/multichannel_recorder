namespace SentenceRecorder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlOpen = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpeakerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.lblListOfSentences = new System.Windows.Forms.Label();
            this.btnDirOpen = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlAdaptText = new System.Windows.Forms.Panel();
            this.richAdaptSentences = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnFinishRecording = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlSig = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nápovìdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOpen.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlAdaptText.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOutputFolder
            // 
            this.dlgOutputFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // pnlOpen
            // 
            this.pnlOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpen.Controls.Add(this.checkedListBox1);
            this.pnlOpen.Controls.Add(this.label7);
            this.pnlOpen.Controls.Add(this.txtMark);
            this.pnlOpen.Controls.Add(this.label6);
            this.pnlOpen.Controls.Add(this.label5);
            this.pnlOpen.Controls.Add(this.label4);
            this.pnlOpen.Controls.Add(this.cmbEnvironment);
            this.pnlOpen.Controls.Add(this.btnStartRecording);
            this.pnlOpen.Controls.Add(this.radioButton2);
            this.pnlOpen.Controls.Add(this.radioButton1);
            this.pnlOpen.Controls.Add(this.label3);
            this.pnlOpen.Controls.Add(this.txtSpeakerName);
            this.pnlOpen.Controls.Add(this.label2);
            this.pnlOpen.Controls.Add(this.lblOutputDirectory);
            this.pnlOpen.Controls.Add(this.lblListOfSentences);
            this.pnlOpen.Controls.Add(this.btnDirOpen);
            this.pnlOpen.Controls.Add(this.btnFileOpen);
            this.pnlOpen.Location = new System.Drawing.Point(0, 23);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Size = new System.Drawing.Size(827, 196);
            this.pnlOpen.TabIndex = 2;
            this.pnlOpen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpen_Paint);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(596, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 124);
            this.checkedListBox1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(592, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Vyberte nahrávací zaøízení:";
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMark.Location = new System.Drawing.Point(188, 130);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(154, 26);
            this.txtMark.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Poznámka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vyberte prostøedí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vyberte pohlaví:";
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Items.AddRange(new object[] {
            "office",
            "noise"});
            this.cmbEnvironment.Location = new System.Drawing.Point(188, 103);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(154, 21);
            this.cmbEnvironment.TabIndex = 17;
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(689, 158);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(126, 30);
            this.btnStartRecording.TabIndex = 15;
            this.btnStartRecording.Text = "Zaèít nahrávat";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(255, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 28);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "žena";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(196, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 28);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "muž";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(356, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "(bez mezer a diakritiky, napøíklad JanNovak)";
            // 
            // txtSpeakerName
            // 
            this.txtSpeakerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSpeakerName.Location = new System.Drawing.Point(188, 162);
            this.txtSpeakerName.Name = "txtSpeakerName";
            this.txtSpeakerName.Size = new System.Drawing.Size(154, 26);
            this.txtSpeakerName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zadejte jméno mluvèího:";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutputDirectory.Location = new System.Drawing.Point(163, 46);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(0, 20);
            this.lblOutputDirectory.TabIndex = 5;
            // 
            // lblListOfSentences
            // 
            this.lblListOfSentences.AutoSize = true;
            this.lblListOfSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblListOfSentences.Location = new System.Drawing.Point(163, 11);
            this.lblListOfSentences.Name = "lblListOfSentences";
            this.lblListOfSentences.Size = new System.Drawing.Size(0, 20);
            this.lblListOfSentences.TabIndex = 4;
            // 
            // btnDirOpen
            // 
            this.btnDirOpen.Location = new System.Drawing.Point(11, 41);
            this.btnDirOpen.Name = "btnDirOpen";
            this.btnDirOpen.Size = new System.Drawing.Size(126, 30);
            this.btnDirOpen.TabIndex = 3;
            this.btnDirOpen.Text = "Vybrat cílový adresáø";
            this.btnDirOpen.UseVisualStyleBackColor = true;
            this.btnDirOpen.Click += new System.EventHandler(this.btnDirOpen_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(12, 6);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(126, 30);
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "Otevøít soubor s texty";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.pnlAdaptText);
            this.pnlStatus.Controls.Add(this.Label1);
            this.pnlStatus.Enabled = false;
            this.pnlStatus.Location = new System.Drawing.Point(0, 225);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(824, 143);
            this.pnlStatus.TabIndex = 3;
            // 
            // pnlAdaptText
            // 
            this.pnlAdaptText.Controls.Add(this.richAdaptSentences);
            this.pnlAdaptText.Location = new System.Drawing.Point(0, 33);
            this.pnlAdaptText.Name = "pnlAdaptText";
            this.pnlAdaptText.Size = new System.Drawing.Size(821, 107);
            this.pnlAdaptText.TabIndex = 10;
            // 
            // richAdaptSentences
            // 
            this.richAdaptSentences.BackColor = System.Drawing.SystemColors.Control;
            this.richAdaptSentences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richAdaptSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richAdaptSentences.ForeColor = System.Drawing.Color.Maroon;
            this.richAdaptSentences.Location = new System.Drawing.Point(5, 10);
            this.richAdaptSentences.Name = "richAdaptSentences";
            this.richAdaptSentences.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richAdaptSentences.Size = new System.Drawing.Size(810, 89);
            this.richAdaptSentences.TabIndex = 9;
            this.richAdaptSentences.Text = "Žalované byl usnesením zdejšího soudu ustanoven opatrovník èárka protože její sou" +
                "èasný pobyt není soudu znám";
            this.richAdaptSentences.TextChanged += new System.EventHandler(this.richAdaptSentences_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(324, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 26);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "pøeètìte vìtu:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtons.Controls.Add(this.label8);
            this.pnlButtons.Controls.Add(this.lblCount);
            this.pnlButtons.Controls.Add(this.btnFinishRecording);
            this.pnlButtons.Controls.Add(this.btnSkip);
            this.pnlButtons.Controls.Add(this.btnSound);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Enabled = false;
            this.pnlButtons.Location = new System.Drawing.Point(0, 367);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(823, 114);
            this.pnlButtons.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(265, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Poèet nahraných vìt:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCount.Location = new System.Drawing.Point(464, 80);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 24);
            this.lblCount.TabIndex = 7;
            // 
            // btnFinishRecording
            // 
            this.btnFinishRecording.Location = new System.Drawing.Point(641, 76);
            this.btnFinishRecording.Name = "btnFinishRecording";
            this.btnFinishRecording.Size = new System.Drawing.Size(174, 30);
            this.btnFinishRecording.TabIndex = 6;
            this.btnFinishRecording.Text = "Konec nahrávání";
            this.btnFinishRecording.UseVisualStyleBackColor = true;
            this.btnFinishRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(396, 42);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(127, 30);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Odstranit (pøeskoèit)";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(262, 42);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(127, 30);
            this.btnSound.TabIndex = 4;
            this.btnSound.Text = "Pøehrát";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(462, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Další ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(329, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(127, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(196, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.FileName = "openFileDialog1";
            // 
            // pnlSig
            // 
            this.pnlSig.Location = new System.Drawing.Point(1, 482);
            this.pnlSig.Name = "pnlSig";
            this.pnlSig.Size = new System.Drawing.Size(821, 146);
            this.pnlSig.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nápovìdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nápovìdaToolStripMenuItem
            // 
            this.nápovìdaToolStripMenuItem.Name = "nápovìdaToolStripMenuItem";
            this.nápovìdaToolStripMenuItem.Size = new System.Drawing.Size(264, 20);
            this.nápovìdaToolStripMenuItem.Text = "Nápovìda - jak postupovat pøi namlouvání vìt";
            this.nápovìdaToolStripMenuItem.Click += new System.EventHandler(this.nápovìdaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 629);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlSig);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlOpen);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SRecorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlOpen.ResumeLayout(false);
            this.pnlOpen.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlAdaptText.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dlgOutputFolder;
        private System.Windows.Forms.Panel pnlOpen;
        private System.Windows.Forms.Button btnDirOpen;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        private System.Windows.Forms.Label lblListOfSentences;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel pnlAdaptText;
        private System.Windows.Forms.RichTextBox richAdaptSentences;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.TextBox txtSpeakerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnFinishRecording;
        private System.Windows.Forms.Panel pnlSig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nápovìdaToolStripMenuItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

