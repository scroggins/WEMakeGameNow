namespace Characterinfo
{
    partial class charInfoGui
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
            this.charNameLable = new System.Windows.Forms.Label();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.listOfCharStatsDisplay = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // charNameLable
            // 
            this.charNameLable.AutoSize = true;
            this.charNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameLable.Location = new System.Drawing.Point(12, 23);
            this.charNameLable.Name = "charNameLable";
            this.charNameLable.Size = new System.Drawing.Size(168, 25);
            this.charNameLable.TabIndex = 0;
            this.charNameLable.Text = "Character Name";
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.playerImage.Location = new System.Drawing.Point(12, 82);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(341, 403);
            this.playerImage.TabIndex = 1;
            this.playerImage.TabStop = false;
            this.playerImage.Click += new System.EventHandler(this.playerImage_Click);
            // 
            // listOfCharStatsDisplay
            // 
            this.listOfCharStatsDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listOfCharStatsDisplay.Location = new System.Drawing.Point(372, 82);
            this.listOfCharStatsDisplay.Name = "listOfCharStatsDisplay";
            this.listOfCharStatsDisplay.Size = new System.Drawing.Size(309, 208);
            this.listOfCharStatsDisplay.TabIndex = 2;
            this.listOfCharStatsDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.listOfCharStatsDisplay_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(372, 428);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 57);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(549, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 50);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(372, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 50);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Location = new System.Drawing.Point(372, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 65);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // charInfoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 501);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listOfCharStatsDisplay);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.charNameLable);
            this.Name = "charInfoGui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.charInfoGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charNameLable;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.Panel listOfCharStatsDisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}

