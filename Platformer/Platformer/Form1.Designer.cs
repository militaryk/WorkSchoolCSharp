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
            this.TmrPlatform = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // TmrPlatform
            // 
            this.TmrPlatform.Tick += new System.EventHandler(this.TmrPlatform_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlGame.Location = new System.Drawing.Point(12, 43);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(780, 354);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(12, 9);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
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
            this.TbUser.Location = new System.Drawing.Point(688, 418);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(100, 20);
            this.TbUser.TabIndex = 6;
            this.TbUser.Text = "username";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.LblUser.Location = new System.Drawing.Point(578, 410);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(104, 28);
            this.LblUser.TabIndex = 7;
            this.LblUser.Text = "Username";
            // 
            // BtnControl
            // 
            this.BtnControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnControl.Location = new System.Drawing.Point(389, 403);
            this.BtnControl.Name = "BtnControl";
            this.BtnControl.Size = new System.Drawing.Size(75, 35);
            this.BtnControl.TabIndex = 8;
            this.BtnControl.Text = "Controls";
            this.BtnControl.UseVisualStyleBackColor = false;
            // 
            // TmrGravity
            // 
            this.TmrGravity.Tick += new System.EventHandler(this.TmrGravity_Tick);
            // 
            // TmrJump
            // 
            this.TmrJump.Interval = 120;
            this.TmrJump.Tick += new System.EventHandler(this.TmrJump_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.BtnControl);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
    }
}

