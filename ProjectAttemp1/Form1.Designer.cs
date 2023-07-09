namespace AblastFromThePast
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
            this.components = new System.ComponentModel.Container();
            this.racePanel = new System.Windows.Forms.Panel();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfTheMainBallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIfficultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryHardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // racePanel
            // 
            this.racePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.racePanel.Location = new System.Drawing.Point(195, 46);
            this.racePanel.Name = "racePanel";
            this.racePanel.Size = new System.Drawing.Size(592, 434);
            this.racePanel.TabIndex = 0;
            this.racePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStart1
            // 
            this.btnStart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart1.BackColor = System.Drawing.Color.Black;
            this.btnStart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart1.ForeColor = System.Drawing.Color.Lime;
            this.btnStart1.Location = new System.Drawing.Point(433, 503);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(103, 38);
            this.btnStart1.TabIndex = 1;
            this.btnStart1.Text = "S T A R T";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 749);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsPoints
            // 
            this.tsPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsPoints.Name = "tsPoints";
            this.tsPoints.Size = new System.Drawing.Size(179, 25);
            this.tsPoints.Text = "toolStripStatusLabel1";
            this.tsPoints.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorOfTheMainBallToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // colorOfTheMainBallToolStripMenuItem
            // 
            this.colorOfTheMainBallToolStripMenuItem.Name = "colorOfTheMainBallToolStripMenuItem";
            this.colorOfTheMainBallToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.colorOfTheMainBallToolStripMenuItem.Text = "Pick your color!";
            this.colorOfTheMainBallToolStripMenuItem.Click += new System.EventHandler(this.colorOfTheMainBallToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setGameModeToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.dIfficultToolStripMenuItem,
            this.veryHardToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.optionsToolStripMenuItem.Text = "Set game mode";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // setGameModeToolStripMenuItem
            // 
            this.setGameModeToolStripMenuItem.Name = "setGameModeToolStripMenuItem";
            this.setGameModeToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.setGameModeToolStripMenuItem.Text = "Easy";
            this.setGameModeToolStripMenuItem.Click += new System.EventHandler(this.setGameModeToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // dIfficultToolStripMenuItem
            // 
            this.dIfficultToolStripMenuItem.Name = "dIfficultToolStripMenuItem";
            this.dIfficultToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.dIfficultToolStripMenuItem.Text = "Hard";
            this.dIfficultToolStripMenuItem.Click += new System.EventHandler(this.dIfficultToolStripMenuItem_Click);
            // 
            // veryHardToolStripMenuItem
            // 
            this.veryHardToolStripMenuItem.Name = "veryHardToolStripMenuItem";
            this.veryHardToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.veryHardToolStripMenuItem.Text = "Very Hard";
            this.veryHardToolStripMenuItem.Click += new System.EventHandler(this.veryHardToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.contentsToolStripMenuItem.Text = "How to play the game?";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(296, 6);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(299, 34);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(166, 565);
            this.pbTime.Maximum = 60;
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(643, 39);
            this.pbTime.TabIndex = 4;
            this.pbTime.Value = 60;
            this.pbTime.Click += new System.EventHandler(this.pbTime_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbScore.ForeColor = System.Drawing.Color.Lime;
            this.lbScore.Location = new System.Drawing.Point(252, 633);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(0, 42);
            this.lbScore.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1031, 781);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.racePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel racePanel;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsPoints;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripMenuItem colorOfTheMainBallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIfficultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veryHardToolStripMenuItem;
        private System.Windows.Forms.Label lbScore;
    }
}

