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
            this.btnDirOpen = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.lblListOfSentences = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlOpen.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpen
            // 
            this.pnlOpen.Controls.Add(this.lblOutputDirectory);
            this.pnlOpen.Controls.Add(this.lblListOfSentences);
            this.pnlOpen.Controls.Add(this.btnDirOpen);
            this.pnlOpen.Controls.Add(this.btnFileOpen);
            this.pnlOpen.Location = new System.Drawing.Point(0, -1);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Size = new System.Drawing.Size(827, 100);
            this.pnlOpen.TabIndex = 2;
            // 
            // btnDirOpen
            // 
            this.btnDirOpen.Location = new System.Drawing.Point(12, 57);
            this.btnDirOpen.Name = "btnDirOpen";
            this.btnDirOpen.Size = new System.Drawing.Size(126, 30);
            this.btnDirOpen.TabIndex = 3;
            this.btnDirOpen.Text = "Vybrat cílový adresáø";
            this.btnDirOpen.UseVisualStyleBackColor = true;
            this.btnDirOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(12, 13);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(126, 30);
            this.btnFileOpen.TabIndex = 2;
            this.btnFileOpen.Text = "Otevøít soubor s texty";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Location = new System.Drawing.Point(0, 98);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(824, 150);
            this.pnlStatus.TabIndex = 3;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.button2);
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Location = new System.Drawing.Point(0, 247);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(823, 158);
            this.pnlButtons.TabIndex = 4;
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.FileName = "openFileDialog1";
            // 
            // lblListOfSentences
            // 
            this.lblListOfSentences.AutoSize = true;
            this.lblListOfSentences.Location = new System.Drawing.Point(166, 17);
            this.lblListOfSentences.Name = "lblListOfSentences";
            this.lblListOfSentences.Size = new System.Drawing.Size(0, 13);
            this.lblListOfSentences.TabIndex = 4;
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(165, 57);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblOutputDirectory.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 405);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpen.ResumeLayout(false);
            this.pnlOpen.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

