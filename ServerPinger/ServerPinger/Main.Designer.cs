namespace ServerPinger
{
    partial class FrmPinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPinger));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnCheckIP = new System.Windows.Forms.Button();
            this.btnStopPinging = new System.Windows.Forms.Button();
            this.nmrPingDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.radICMP = new System.Windows.Forms.RadioButton();
            this.radTCP = new System.Windows.Forms.RadioButton();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPlaySong = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLaunchPath = new System.Windows.Forms.TextBox();
            this.chkLaunchProgram = new System.Windows.Forms.CheckBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnLoadIPs = new System.Windows.Forms.Button();
            this.btnSoundLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPingDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(56, 155);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(219, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // btnCheckIP
            // 
            this.btnCheckIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCheckIP.Location = new System.Drawing.Point(433, 89);
            this.btnCheckIP.Name = "btnCheckIP";
            this.btnCheckIP.Size = new System.Drawing.Size(73, 23);
            this.btnCheckIP.TabIndex = 1;
            this.btnCheckIP.Text = "Check";
            this.btnCheckIP.UseVisualStyleBackColor = true;
            this.btnCheckIP.Click += new System.EventHandler(this.BtnCheckIP_Click);
            // 
            // btnStopPinging
            // 
            this.btnStopPinging.Enabled = false;
            this.btnStopPinging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStopPinging.Location = new System.Drawing.Point(433, 118);
            this.btnStopPinging.Name = "btnStopPinging";
            this.btnStopPinging.Size = new System.Drawing.Size(73, 23);
            this.btnStopPinging.TabIndex = 2;
            this.btnStopPinging.Text = "Stop";
            this.btnStopPinging.UseVisualStyleBackColor = true;
            this.btnStopPinging.Click += new System.EventHandler(this.BtnStopPinging_Click);
            // 
            // nmrPingDelay
            // 
            this.nmrPingDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nmrPingDelay.Location = new System.Drawing.Point(183, 179);
            this.nmrPingDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrPingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPingDelay.Name = "nmrPingDelay";
            this.nmrPingDelay.Size = new System.Drawing.Size(39, 21);
            this.nmrPingDelay.TabIndex = 5;
            this.nmrPingDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPingDelay.ValueChanged += new System.EventHandler(this.NmrPingDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(128, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Interval:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(228, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "second";
            // 
            // radICMP
            // 
            this.radICMP.AutoSize = true;
            this.radICMP.Checked = true;
            this.radICMP.Location = new System.Drawing.Point(6, 19);
            this.radICMP.Name = "radICMP";
            this.radICMP.Size = new System.Drawing.Size(51, 17);
            this.radICMP.TabIndex = 0;
            this.radICMP.TabStop = true;
            this.radICMP.Text = "ICMP";
            this.radICMP.UseVisualStyleBackColor = true;
            // 
            // radTCP
            // 
            this.radTCP.AutoSize = true;
            this.radTCP.Location = new System.Drawing.Point(6, 42);
            this.radTCP.Name = "radTCP";
            this.radTCP.Size = new System.Drawing.Size(46, 17);
            this.radTCP.TabIndex = 1;
            this.radTCP.Text = "TCP";
            this.radTCP.UseVisualStyleBackColor = true;
            this.radTCP.CheckedChanged += new System.EventHandler(this.RadTCP_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(56, 181);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(66, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radICMP);
            this.groupBox1.Controls.Add(this.radTCP);
            this.groupBox1.Location = new System.Drawing.Point(434, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(74, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocol";
            // 
            // chkPlaySong
            // 
            this.chkPlaySong.AutoSize = true;
            this.chkPlaySong.Checked = true;
            this.chkPlaySong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaySong.Location = new System.Drawing.Point(348, 155);
            this.chkPlaySong.Name = "chkPlaySong";
            this.chkPlaySong.Size = new System.Drawing.Size(138, 17);
            this.chkPlaySong.TabIndex = 1;
            this.chkPlaySong.TabStop = false;
            this.chkPlaySong.Text = "Play sound when online";
            this.chkPlaySong.UseVisualStyleBackColor = true;
            this.chkPlaySong.CheckedChanged += new System.EventHandler(this.ChkPlaySong_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F);
            this.btnClear.Location = new System.Drawing.Point(12, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 14);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtLaunchPath
            // 
            this.txtLaunchPath.Location = new System.Drawing.Point(287, 201);
            this.txtLaunchPath.Name = "txtLaunchPath";
            this.txtLaunchPath.ReadOnly = true;
            this.txtLaunchPath.Size = new System.Drawing.Size(219, 20);
            this.txtLaunchPath.TabIndex = 11;
            this.txtLaunchPath.Text = "C:\\MapleRoyals\\MapleRoyals.exe";
            this.txtLaunchPath.Visible = false;
            this.txtLaunchPath.Click += new System.EventHandler(this.TxtLaunchPath_Click);
            // 
            // chkLaunchProgram
            // 
            this.chkLaunchProgram.AutoSize = true;
            this.chkLaunchProgram.Location = new System.Drawing.Point(348, 178);
            this.chkLaunchProgram.Name = "chkLaunchProgram";
            this.chkLaunchProgram.Size = new System.Drawing.Size(160, 17);
            this.chkLaunchProgram.TabIndex = 12;
            this.chkLaunchProgram.TabStop = false;
            this.chkLaunchProgram.Text = "Launch program on success";
            this.chkLaunchProgram.UseVisualStyleBackColor = true;
            this.chkLaunchProgram.CheckedChanged += new System.EventHandler(this.ChkLaunchProgram_CheckedChanged);
            // 
            // lstLog
            // 
            this.lstLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(12, 17);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(415, 124);
            this.lstLog.TabIndex = 13;
            this.lstLog.DoubleClick += new System.EventHandler(this.LstLog_DoubleClick);
            // 
            // btnLoadIPs
            // 
            this.btnLoadIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F);
            this.btnLoadIPs.Location = new System.Drawing.Point(42, 1);
            this.btnLoadIPs.Name = "btnLoadIPs";
            this.btnLoadIPs.Size = new System.Drawing.Size(24, 14);
            this.btnLoadIPs.TabIndex = 14;
            this.btnLoadIPs.TabStop = false;
            this.btnLoadIPs.UseVisualStyleBackColor = true;
            this.btnLoadIPs.Click += new System.EventHandler(this.BtnLoadIPs_Click);
            // 
            // btnSoundLocation
            // 
            this.btnSoundLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F);
            this.btnSoundLocation.Location = new System.Drawing.Point(482, 157);
            this.btnSoundLocation.Name = "btnSoundLocation";
            this.btnSoundLocation.Size = new System.Drawing.Size(24, 14);
            this.btnSoundLocation.TabIndex = 15;
            this.btnSoundLocation.TabStop = false;
            this.btnSoundLocation.UseVisualStyleBackColor = true;
            this.btnSoundLocation.Click += new System.EventHandler(this.btnSoundLocation_Click);
            // 
            // FrmPinger
            // 
            this.AcceptButton = this.btnCheckIP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 228);
            this.Controls.Add(this.btnSoundLocation);
            this.Controls.Add(this.btnLoadIPs);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.chkLaunchProgram);
            this.Controls.Add(this.txtLaunchPath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkPlaySong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrPingDelay);
            this.Controls.Add(this.btnStopPinging);
            this.Controls.Add(this.btnCheckIP);
            this.Controls.Add(this.txtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Pinger";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPingDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnCheckIP;
        private System.Windows.Forms.Button btnStopPinging;
        private System.Windows.Forms.NumericUpDown nmrPingDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radICMP;
        private System.Windows.Forms.RadioButton radTCP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkPlaySong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLaunchPath;
        private System.Windows.Forms.CheckBox chkLaunchProgram;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnLoadIPs;
        private System.Windows.Forms.Button btnSoundLocation;
    }
}

