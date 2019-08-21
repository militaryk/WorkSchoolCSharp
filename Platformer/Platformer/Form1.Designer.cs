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
            this.LblDiffDet = new System.Windows.Forms.Label();
            this.LblDiff = new System.Windows.Forms.Label();
            this.TbDiff = new System.Windows.Forms.TextBox();
            this.BtnConfrimDiff = new System.Windows.Forms.Button();
            this.LblScore = new System.Windows.Forms.Label();
            this.TmrPerson = new System.Windows.Forms.Timer(this.components);
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnInstruction = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TmrGravity = new System.Windows.Forms.Timer(this.components);
            this.TmrJump = new System.Windows.Forms.Timer(this.components);
            this.Lbldiffmin = new System.Windows.Forms.Label();
            this.LblXP = new System.Windows.Forms.Label();
            this.LblDifficulty = new System.Windows.Forms.Label();
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
            this.PnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.TbDiff.Location = new System.Drawing.Point(478, 427);
            this.TbDiff.Name = "TbDiff";
            this.TbDiff.Size = new System.Drawing.Size(100, 20);
            this.TbDiff.TabIndex = 2;
            this.TbDiff.Text = " ";
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
            this.BtnStart.Location = new System.Drawing.Point(12, 403);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(228, 35);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnInstruction
            // 
            this.BtnInstruction.BackColor = System.Drawing.Color.Aqua;
            this.BtnInstruction.Location = new System.Drawing.Point(246, 403);
            this.BtnInstruction.Name = "BtnInstruction";
            this.BtnInstruction.Size = new System.Drawing.Size(146, 35);
            this.BtnInstruction.TabIndex = 5;
            this.BtnInstruction.Text = "Instructions";
            this.BtnInstruction.UseVisualStyleBackColor = false;
            this.BtnInstruction.Click += new System.EventHandler(this.BtnInstruction_Click);
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
            // Lbldiffmin
            // 
            this.Lbldiffmin.AutoSize = true;
            this.Lbldiffmin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Lbldiffmin.Location = new System.Drawing.Point(496, 5);
            this.Lbldiffmin.Name = "Lbldiffmin";
            this.Lbldiffmin.Size = new System.Drawing.Size(20, 23);
            this.Lbldiffmin.TabIndex = 10;
            this.Lbldiffmin.Text = "2";
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
            this.Controls.Add(this.BtnInstruction);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblScore);
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
        private System.Windows.Forms.Button BtnInstruction;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Timer TmrGravity;
        private System.Windows.Forms.Timer TmrJump;
        private System.Windows.Forms.Button BtnConfrimDiff;
        private System.Windows.Forms.Label LblDiffDet;
        private System.Windows.Forms.TextBox TbDiff;
        private System.Windows.Forms.Label LblDiff;
        private System.Windows.Forms.Label Lbldiffmin;
        private System.Windows.Forms.Label LblXP;
        private System.Windows.Forms.Label LblDifficulty;
    }
}

