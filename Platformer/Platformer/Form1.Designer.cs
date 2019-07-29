namespace Platformer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TmrPlatform = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.LblDiffDet = new System.Windows.Forms.Label();
            this.LblDiff = new System.Windows.Forms.Label();
            this.TbDiff = new System.Windows.Forms.TextBox();
            this.BtnConfrimDiff = new System.Windows.Forms.Button();
            this.LblScore = new System.Windows.Forms.Label();
            this.TmrPerson = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnControl = new System.Windows.Forms.Button();
            this.TmrGravity = new System.Windows.Forms.Timer(this.components);
            this.TmrJump = new System.Windows.Forms.Timer(this.components);
            this.BtnBack = new System.Windows.Forms.Button();
            this.Lbldiffmin = new System.Windows.Forms.Label();
            this.LblXP = new System.Windows.Forms.Label();
            this.LblDifficulty = new System.Windows.Forms.Label();
            this.TmrPlatformChange = new System.Windows.Forms.Timer(this.components);
            this.TmrDiff = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmrPlatform
            // 
            this.TmrPlatform.Interval = 50;
            this.TmrPlatform.Tick += new System.EventHandler(this.TmrPlatform_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGame.BackgroundImage")));
            this.PnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlGame.Controls.Add(this.BtnBack);
            this.PnlGame.Controls.Add(this.BtnControl);
            this.PnlGame.Location = new System.Drawing.Point(12, 43);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(780, 354);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // LblDiffDet
            // 
            this.LblDiffDet.AutoSize = true;
            this.LblDiffDet.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LblDiffDet.Location = new System.Drawing.Point(400, 405);
            this.LblDiffDet.Name = "LblDiffDet";
            this.LblDiffDet.Size = new System.Drawing.Size(276, 19);
            this.LblDiffDet.TabIndex = 3;
            this.LblDiffDet.Text = "Please Enter Difficulty Between 1 and 10";
            // 
            // LblDiff
            // 
            this.LblDiff.AutoSize = true;
            this.LblDiff.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.LblDiff.Location = new System.Drawing.Point(398, 427);
            this.LblDiff.Name = "LblDiff";
            this.LblDiff.Size = new System.Drawing.Size(73, 19);
            this.LblDiff.TabIndex = 1;
            this.LblDiff.Text = "Difficulty";
            // 
            // TbDiff
            // 
            this.TbDiff.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.TbDiff.Location = new System.Drawing.Point(477, 426);
            this.TbDiff.Name = "TbDiff";
            this.TbDiff.Size = new System.Drawing.Size(100, 20);
            this.TbDiff.TabIndex = 2;
            this.TbDiff.Text = "0";
            this.TbDiff.TextChanged += new System.EventHandler(this.TbDiff_TextChanged);
            this.TbDiff.Leave += new System.EventHandler(this.TbDiff_Leave);
            // 
            // BtnConfrimDiff
            // 
            this.BtnConfrimDiff.Location = new System.Drawing.Point(583, 426);
            this.BtnConfrimDiff.Name = "BtnConfrimDiff";
            this.BtnConfrimDiff.Size = new System.Drawing.Size(99, 20);
            this.BtnConfrimDiff.TabIndex = 0;
            this.BtnConfrimDiff.Text = "Confirm Difficulty";
            this.BtnConfrimDiff.UseVisualStyleBackColor = true;
            this.BtnConfrimDiff.Click += new System.EventHandler(this.BtnConfrimDiff_Click);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.LblScore.Location = new System.Drawing.Point(49, 2);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(20, 23);
            this.LblScore.TabIndex = 2;
            this.LblScore.Text = "0";
            // 
            // TmrPerson
            // 
            this.TmrPerson.Tick += new System.EventHandler(this.TmrPerson_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Lime;
            this.BtnStart.Location = new System.Drawing.Point(41, 403);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 35);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Red;
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(158, 403);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 35);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.Aqua;
            this.BtnConfirm.Location = new System.Drawing.Point(275, 403);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 35);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Instructions";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(692, 425);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(100, 20);
            this.TbUser.TabIndex = 6;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.LblUser.Location = new System.Drawing.Point(688, 396);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(104, 28);
            this.LblUser.TabIndex = 7;
            this.LblUser.Text = "Username";
            // 
            // BtnControl
            // 
            this.BtnControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnControl.Location = new System.Drawing.Point(270, 187);
            this.BtnControl.Name = "BtnControl";
            this.BtnControl.Size = new System.Drawing.Size(75, 35);
            this.BtnControl.TabIndex = 8;
            this.BtnControl.Text = "Controls";
            this.BtnControl.UseVisualStyleBackColor = false;
            this.BtnControl.Visible = false;
            this.BtnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // TmrGravity
            // 
            this.TmrGravity.Interval = 50;
            this.TmrGravity.Tick += new System.EventHandler(this.TmrGravity_Tick);
            // 
            // TmrJump
            // 
            this.TmrJump.Interval = 700;
            this.TmrJump.Tick += new System.EventHandler(this.TmrJump_Tick);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBack.Location = new System.Drawing.Point(189, 187);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 35);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Lbldiffmin
            // 
            this.Lbldiffmin.AutoSize = true;
            this.Lbldiffmin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Lbldiffmin.Location = new System.Drawing.Point(496, 5);
            this.Lbldiffmin.Name = "Lbldiffmin";
            this.Lbldiffmin.Size = new System.Drawing.Size(17, 23);
            this.Lbldiffmin.TabIndex = 10;
            this.Lbldiffmin.Text = "1";
            // 
            // LblXP
            // 
            this.LblXP.AutoSize = true;
            this.LblXP.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.LblXP.Location = new System.Drawing.Point(8, 2);
            this.LblXP.Name = "LblXP";
            this.LblXP.Size = new System.Drawing.Size(35, 23);
            this.LblXP.TabIndex = 11;
            this.LblXP.Text = "XP:";
            // 
            // LblDifficulty
            // 
            this.LblDifficulty.AutoSize = true;
            this.LblDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.LblDifficulty.Location = new System.Drawing.Point(400, 5);
            this.LblDifficulty.Name = "LblDifficulty";
            this.LblDifficulty.Size = new System.Drawing.Size(90, 23);
            this.LblDifficulty.TabIndex = 12;
            this.LblDifficulty.Text = "Difficulty:";
            // 
            // TmrPlatformChange
            // 
            this.TmrPlatformChange.Enabled = true;
            this.TmrPlatformChange.Interval = 10000;
            this.TmrPlatformChange.Tick += new System.EventHandler(this.TmrPlatformChange_Tick);
            // 
            // TmrDiff
            // 
            this.TmrDiff.Interval = 10000;
            this.TmrDiff.Tick += new System.EventHandler(this.TmrDiff_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.LblDiff);
            this.Controls.Add(this.LblDiffDet);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.LblDifficulty);
            this.Controls.Add(this.LblXP);
            this.Controls.Add(this.Lbldiffmin);
            this.Controls.Add(this.TbDiff);
            this.Controls.Add(this.BtnConfrimDiff);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer TmrPerson;
        private System.Windows.Forms.Timer TmrPlatform;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnControl;
        private System.Windows.Forms.Timer TmrGravity;
        private System.Windows.Forms.Timer TmrJump;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnConfrimDiff;
        private System.Windows.Forms.Label LblDiffDet;
        private System.Windows.Forms.TextBox TbDiff;
        private System.Windows.Forms.Label LblDiff;
        private System.Windows.Forms.Label Lbldiffmin;
        private System.Windows.Forms.Label LblXP;
        private System.Windows.Forms.Label LblDifficulty;
        private System.Windows.Forms.Timer TmrPlatformChange;
        private System.Windows.Forms.Timer TmrDiff;
    }
}

