namespace WindowsFormsApp1
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelscore = new System.Windows.Forms.Label();
            this.labellives = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.infiniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTREMEMEGAMADNESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laser = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.Control;
            this.PnlGame.Location = new System.Drawing.Point(12, 35);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(511, 376);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(592, 416);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 1;
            this.LblScore.Text = "0";
            this.LblScore.Click += new System.EventHandler(this.LblScore_Click);
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(718, 416);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(13, 13);
            this.LblLives.TabIndex = 2;
            this.LblLives.Text = "5";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(602, 306);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 4;
            this.TxtName.Text = "Person";
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(553, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 146);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.labelscore.Location = new System.Drawing.Point(569, 387);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(59, 24);
            this.labelscore.TabIndex = 7;
            this.labelscore.Text = "Score";
            // 
            // labellives
            // 
            this.labellives.AutoSize = true;
            this.labellives.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.labellives.Location = new System.Drawing.Point(695, 387);
            this.labellives.Name = "labellives";
            this.labellives.Size = new System.Drawing.Size(52, 24);
            this.labellives.TabIndex = 8;
            this.labellives.Text = "Lives";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.labeluser.Location = new System.Drawing.Point(619, 81);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(69, 33);
            this.labeluser.TabIndex = 9;
            this.labeluser.Text = "User";
            this.labeluser.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(613, 332);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lbluser.Location = new System.Drawing.Point(609, 279);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(93, 24);
            this.lbluser.TabIndex = 11;
            this.lbluser.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.Location = new System.Drawing.Point(529, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To My Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "High Score :";
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.highscore.Location = new System.Drawing.Point(172, 416);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(29, 31);
            this.highscore.TabIndex = 14;
            this.highscore.Text = "0";
            this.highscore.Click += new System.EventHandler(this.highscore_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.Interval = 20000;
            this.Difficulty.Tick += new System.EventHandler(this.Difficulty_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livesToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(414, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(152, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // livesToolStripMenuItem
            // 
            this.livesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.infiniteToolStripMenuItem});
            this.livesToolStripMenuItem.Name = "livesToolStripMenuItem";
            this.livesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.livesToolStripMenuItem.Text = "Lives";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem2.Text = "+1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem3.Text = "-1";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // infiniteToolStripMenuItem
            // 
            this.infiniteToolStripMenuItem.Name = "infiniteToolStripMenuItem";
            this.infiniteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.infiniteToolStripMenuItem.Text = "Infinite";
            this.infiniteToolStripMenuItem.Click += new System.EventHandler(this.infiniteToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem4.Text = "+1";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem5.Text = "+10";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem6.Text = "-1";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem7.Text = "-10";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boringToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.decentToolStripMenuItem,
            this.crazyToolStripMenuItem,
            this.eXTREMEMEGAMADNESSToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // boringToolStripMenuItem
            // 
            this.boringToolStripMenuItem.Name = "boringToolStripMenuItem";
            this.boringToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.boringToolStripMenuItem.Text = "Boring";
            this.boringToolStripMenuItem.Click += new System.EventHandler(this.boringToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // decentToolStripMenuItem
            // 
            this.decentToolStripMenuItem.Name = "decentToolStripMenuItem";
            this.decentToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.decentToolStripMenuItem.Text = "Decent";
            this.decentToolStripMenuItem.Click += new System.EventHandler(this.decentToolStripMenuItem_Click);
            // 
            // crazyToolStripMenuItem
            // 
            this.crazyToolStripMenuItem.Name = "crazyToolStripMenuItem";
            this.crazyToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.crazyToolStripMenuItem.Text = "Crazy";
            this.crazyToolStripMenuItem.Click += new System.EventHandler(this.crazyToolStripMenuItem_Click);
            // 
            // eXTREMEMEGAMADNESSToolStripMenuItem
            // 
            this.eXTREMEMEGAMADNESSToolStripMenuItem.Name = "eXTREMEMEGAMADNESSToolStripMenuItem";
            this.eXTREMEMEGAMADNESSToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.eXTREMEMEGAMADNESSToolStripMenuItem.Text = "EXTREME MEGA MADNESS";
            this.eXTREMEMEGAMADNESSToolStripMenuItem.Click += new System.EventHandler(this.eXTREMEMEGAMADNESSToolStripMenuItem_Click);
            // 
            // laser
            // 
            this.laser.Tick += new System.EventHandler(this.laser_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labellives);
            this.Controls.Add(this.labelscore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Label labellives;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Timer Difficulty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem infiniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crazyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTREMEMEGAMADNESSToolStripMenuItem;
        private System.Windows.Forms.Timer laser;
    }
}

