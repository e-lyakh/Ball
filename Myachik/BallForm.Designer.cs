namespace Myachik
{
    partial class BallForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStart_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeed5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpeedCrazy = new System.Windows.Forms.ToolStripMenuItem();
            this.ball = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmStart_Stop,
            this.tsmSpeed});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(378, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "&File";
            // 
            // tsmFileExit
            // 
            this.tsmFileExit.Name = "tsmFileExit";
            this.tsmFileExit.Size = new System.Drawing.Size(92, 22);
            this.tsmFileExit.Text = "E&xit";
            this.tsmFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmStart_Stop
            // 
            this.tsmStart_Stop.Name = "tsmStart_Stop";
            this.tsmStart_Stop.Size = new System.Drawing.Size(78, 20);
            this.tsmStart_Stop.Text = "&Start / Stop";
            this.tsmStart_Stop.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
            // 
            // tsmSpeed
            // 
            this.tsmSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSpeed1,
            this.tsmSpeed2,
            this.tsmSpeed3,
            this.tsmSpeed4,
            this.tsmSpeed5,
            this.tsmSpeedCrazy});
            this.tsmSpeed.Name = "tsmSpeed";
            this.tsmSpeed.Size = new System.Drawing.Size(51, 20);
            this.tsmSpeed.Text = "S&peed";
            // 
            // tsmSpeed1
            // 
            this.tsmSpeed1.Checked = true;
            this.tsmSpeed1.CheckOnClick = true;
            this.tsmSpeed1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmSpeed1.Name = "tsmSpeed1";
            this.tsmSpeed1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.tsmSpeed1.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeed1.Tag = "250";
            this.tsmSpeed1.Text = "1";
            // 
            // tsmSpeed2
            // 
            this.tsmSpeed2.CheckOnClick = true;
            this.tsmSpeed2.Name = "tsmSpeed2";
            this.tsmSpeed2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.tsmSpeed2.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeed2.Tag = "200";
            this.tsmSpeed2.Text = "2";
            // 
            // tsmSpeed3
            // 
            this.tsmSpeed3.CheckOnClick = true;
            this.tsmSpeed3.Name = "tsmSpeed3";
            this.tsmSpeed3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.tsmSpeed3.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeed3.Tag = "150";
            this.tsmSpeed3.Text = "3";
            // 
            // tsmSpeed4
            // 
            this.tsmSpeed4.CheckOnClick = true;
            this.tsmSpeed4.Name = "tsmSpeed4";
            this.tsmSpeed4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.tsmSpeed4.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeed4.Tag = "100";
            this.tsmSpeed4.Text = "4";
            // 
            // tsmSpeed5
            // 
            this.tsmSpeed5.CheckOnClick = true;
            this.tsmSpeed5.Name = "tsmSpeed5";
            this.tsmSpeed5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.tsmSpeed5.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeed5.Tag = "50";
            this.tsmSpeed5.Text = "5";
            // 
            // tsmSpeedCrazy
            // 
            this.tsmSpeedCrazy.ForeColor = System.Drawing.Color.Maroon;
            this.tsmSpeedCrazy.Name = "tsmSpeedCrazy";
            this.tsmSpeedCrazy.Size = new System.Drawing.Size(116, 22);
            this.tsmSpeedCrazy.Tag = "5";
            this.tsmSpeedCrazy.Text = "Crazy";
            // 
            // ball
            // 
            this.ball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ball.BackColor = System.Drawing.Color.Cyan;
            this.ball.FlatAppearance.BorderSize = 0;
            this.ball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ball.ForeColor = System.Drawing.Color.Teal;
            this.ball.Location = new System.Drawing.Point(175, 131);
            this.ball.Margin = new System.Windows.Forms.Padding(0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 50);
            this.ball.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ball, "Click to run or stop");
            this.ball.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(400, 350);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "BallForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squeezing Ball";
            this.Load += new System.EventHandler(this.BallForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmStart_Stop;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed1;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed2;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed3;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed4;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed5;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeedCrazy;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

