namespace RandomAlphabet
{
    partial class FromMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAlphabet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.LblTmr = new System.Windows.Forms.Label();
            this.CmbTimeChoose = new System.Windows.Forms.ComboBox();
            this.TbrVoice = new System.Windows.Forms.TrackBar();
            this.BtnBgmPause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClosePlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TbrVoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNext.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNext.Location = new System.Drawing.Point(318, 399);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(179, 81);
            this.BtnNext.TabIndex = 0;
            this.BtnNext.Text = "下一个";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "随机的声母";
            // 
            // LblAlphabet
            // 
            this.LblAlphabet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAlphabet.AutoSize = true;
            this.LblAlphabet.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlphabet.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblAlphabet.Location = new System.Drawing.Point(119, 139);
            this.LblAlphabet.Name = "LblAlphabet";
            this.LblAlphabet.Size = new System.Drawing.Size(201, 225);
            this.LblAlphabet.TabIndex = 2;
            this.LblAlphabet.Text = "A";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(512, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "倒计时";
            // 
            // Tmr
            // 
            this.Tmr.Enabled = true;
            this.Tmr.Interval = 1000;
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // LblTmr
            // 
            this.LblTmr.AutoSize = true;
            this.LblTmr.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTmr.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblTmr.Location = new System.Drawing.Point(516, 191);
            this.LblTmr.Name = "LblTmr";
            this.LblTmr.Size = new System.Drawing.Size(179, 131);
            this.LblTmr.TabIndex = 4;
            this.LblTmr.Text = "15";
            // 
            // CmbTimeChoose
            // 
            this.CmbTimeChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTimeChoose.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbTimeChoose.FormattingEnabled = true;
            this.CmbTimeChoose.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.CmbTimeChoose.Location = new System.Drawing.Point(683, 64);
            this.CmbTimeChoose.Name = "CmbTimeChoose";
            this.CmbTimeChoose.Size = new System.Drawing.Size(187, 51);
            this.CmbTimeChoose.TabIndex = 5;
            // 
            // TbrVoice
            // 
            this.TbrVoice.Location = new System.Drawing.Point(17, 34);
            this.TbrVoice.Name = "TbrVoice";
            this.TbrVoice.Size = new System.Drawing.Size(221, 90);
            this.TbrVoice.TabIndex = 6;
            this.TbrVoice.Value = 1;
            this.TbrVoice.ValueChanged += new System.EventHandler(this.TbrVoice_ValueChanged);
            // 
            // BtnBgmPause
            // 
            this.BtnBgmPause.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBgmPause.Location = new System.Drawing.Point(23, 570);
            this.BtnBgmPause.Name = "BtnBgmPause";
            this.BtnBgmPause.Size = new System.Drawing.Size(177, 62);
            this.BtnBgmPause.TabIndex = 7;
            this.BtnBgmPause.Text = "暂停Bgm";
            this.BtnBgmPause.UseVisualStyleBackColor = true;
            this.BtnBgmPause.Click += new System.EventHandler(this.BtnBgmPause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbrVoice);
            this.groupBox1.Location = new System.Drawing.Point(423, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音量调节";
            // 
            // BtnClosePlay
            // 
            this.BtnClosePlay.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClosePlay.Location = new System.Drawing.Point(222, 570);
            this.BtnClosePlay.Name = "BtnClosePlay";
            this.BtnClosePlay.Size = new System.Drawing.Size(177, 62);
            this.BtnClosePlay.TabIndex = 9;
            this.BtnClosePlay.Text = "停止Bgm";
            this.BtnClosePlay.UseVisualStyleBackColor = true;
            this.BtnClosePlay.Click += new System.EventHandler(this.BtnClosePlay_Click);
            // 
            // FromMain
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 644);
            this.Controls.Add(this.BtnClosePlay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBgmPause);
            this.Controls.Add(this.CmbTimeChoose);
            this.Controls.Add(this.LblTmr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblAlphabet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FromMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "循环声母接龙游戏";
            this.Load += new System.EventHandler(this.FromMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbrVoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAlphabet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.Label LblTmr;
        private System.Windows.Forms.ComboBox CmbTimeChoose;
        private System.Windows.Forms.TrackBar TbrVoice;
        private System.Windows.Forms.Button BtnBgmPause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnClosePlay;
    }
}

