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
            System.Windows.Forms.Timer TmrPlatform;
            this.PnlGame = new System.Windows.Forms.Panel();
            this.LblCheck = new System.Windows.Forms.Label();
            this.LblSpeed1 = new System.Windows.Forms.Label();
            this.LblSpeed2 = new System.Windows.Forms.Label();
            this.LblSpeed3 = new System.Windows.Forms.Label();
            TmrPlatform = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlGame.Location = new System.Drawing.Point(12, 43);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(776, 369);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrPlatform
            // 
            TmrPlatform.Enabled = true;
            TmrPlatform.Tick += new System.EventHandler(this.TmrPlatform_Tick);
            // 
            // LblCheck
            // 
            this.LblCheck.AutoSize = true;
            this.LblCheck.Location = new System.Drawing.Point(736, 18);
            this.LblCheck.Name = "LblCheck";
            this.LblCheck.Size = new System.Drawing.Size(13, 13);
            this.LblCheck.TabIndex = 1;
            this.LblCheck.Text = "0";
            // 
            // LblSpeed1
            // 
            this.LblSpeed1.AutoSize = true;
            this.LblSpeed1.Location = new System.Drawing.Point(441, 18);
            this.LblSpeed1.Name = "LblSpeed1";
            this.LblSpeed1.Size = new System.Drawing.Size(58, 13);
            this.LblSpeed1.TabIndex = 2;
            this.LblSpeed1.Text = "LblSpeed1";
            // 
            // LblSpeed2
            // 
            this.LblSpeed2.AutoSize = true;
            this.LblSpeed2.Location = new System.Drawing.Point(505, 18);
            this.LblSpeed2.Name = "LblSpeed2";
            this.LblSpeed2.Size = new System.Drawing.Size(58, 13);
            this.LblSpeed2.TabIndex = 3;
            this.LblSpeed2.Tag = "";
            this.LblSpeed2.Text = "LblSpeed2";
            // 
            // LblSpeed3
            // 
            this.LblSpeed3.AutoSize = true;
            this.LblSpeed3.Location = new System.Drawing.Point(569, 18);
            this.LblSpeed3.Name = "LblSpeed3";
            this.LblSpeed3.Size = new System.Drawing.Size(58, 13);
            this.LblSpeed3.TabIndex = 4;
            this.LblSpeed3.Tag = "";
            this.LblSpeed3.Text = "LblSpeed3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSpeed3);
            this.Controls.Add(this.LblSpeed2);
            this.Controls.Add(this.LblSpeed1);
            this.Controls.Add(this.LblCheck);
            this.Controls.Add(this.PnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label LblCheck;
        private System.Windows.Forms.Label LblSpeed1;
        private System.Windows.Forms.Label LblSpeed2;
        private System.Windows.Forms.Label LblSpeed3;
    }
}

