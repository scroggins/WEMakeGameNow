namespace WeMakeGameNow
{
    partial class CharacterInfoGui
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
            this.returnToOptions = new System.Windows.Forms.Button();
            this.charNameLAbel = new System.Windows.Forms.Label();
            this.playerImagePanel = new System.Windows.Forms.Panel();
            this.listOfCharStatsPanel = new System.Windows.Forms.Panel();
            this.playerImageLabel = new System.Windows.Forms.Label();
            this.listOFCharStatLabel = new System.Windows.Forms.Label();
            this.extraTopLeftPanel = new System.Windows.Forms.Panel();
            this.extraTopRightPanel = new System.Windows.Forms.Panel();
            this.extraMiddlePAnel = new System.Windows.Forms.Panel();
            this.extraBottomPanel = new System.Windows.Forms.Panel();
            this.playerImagePanel.SuspendLayout();
            this.listOfCharStatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnToOptions
            // 
            this.returnToOptions.BackColor = System.Drawing.Color.Yellow;
            this.returnToOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToOptions.Location = new System.Drawing.Point(432, 12);
            this.returnToOptions.Name = "returnToOptions";
            this.returnToOptions.Size = new System.Drawing.Size(199, 61);
            this.returnToOptions.TabIndex = 0;
            this.returnToOptions.Text = "Return to Options";
            this.returnToOptions.UseCompatibleTextRendering = true;
            this.returnToOptions.UseVisualStyleBackColor = false;
            this.returnToOptions.Click += new System.EventHandler(this.returnToOptions_Click);
            // 
            // charNameLAbel
            // 
            this.charNameLAbel.AutoSize = true;
            this.charNameLAbel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charNameLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameLAbel.Location = new System.Drawing.Point(25, 36);
            this.charNameLAbel.Name = "charNameLAbel";
            this.charNameLAbel.Size = new System.Drawing.Size(168, 25);
            this.charNameLAbel.TabIndex = 1;
            this.charNameLAbel.Text = "Character Name";
            this.charNameLAbel.Click += new System.EventHandler(this.charNameLAbel_Click);
            // 
            // playerImagePanel
            // 
            this.playerImagePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerImagePanel.Controls.Add(this.playerImageLabel);
            this.playerImagePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerImagePanel.Location = new System.Drawing.Point(4, 106);
            this.playerImagePanel.Name = "playerImagePanel";
            this.playerImagePanel.Size = new System.Drawing.Size(322, 656);
            this.playerImagePanel.TabIndex = 2;
            this.playerImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerImagePanel_Paint);
            // 
            // listOfCharStatsPanel
            // 
            this.listOfCharStatsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfCharStatsPanel.Controls.Add(this.listOFCharStatLabel);
            this.listOfCharStatsPanel.Location = new System.Drawing.Point(332, 106);
            this.listOfCharStatsPanel.Name = "listOfCharStatsPanel";
            this.listOfCharStatsPanel.Size = new System.Drawing.Size(299, 299);
            this.listOfCharStatsPanel.TabIndex = 3;
            this.listOfCharStatsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listOfCharStatsPanel_Paint);
            // 
            // playerImageLabel
            // 
            this.playerImageLabel.AutoSize = true;
            this.playerImageLabel.Location = new System.Drawing.Point(6, 169);
            this.playerImageLabel.Name = "playerImageLabel";
            this.playerImageLabel.Size = new System.Drawing.Size(287, 25);
            this.playerImageLabel.TabIndex = 0;
            this.playerImageLabel.Text = "Player Image (Equip Armor?)";
            this.playerImageLabel.Click += new System.EventHandler(this.playerImageLabel_Click);
            // 
            // listOFCharStatLabel
            // 
            this.listOFCharStatLabel.AutoSize = true;
            this.listOFCharStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOFCharStatLabel.Location = new System.Drawing.Point(3, 79);
            this.listOFCharStatLabel.Name = "listOFCharStatLabel";
            this.listOFCharStatLabel.Size = new System.Drawing.Size(267, 25);
            this.listOFCharStatLabel.TabIndex = 0;
            this.listOFCharStatLabel.Text = "List Of Character Statistics";
            this.listOFCharStatLabel.Click += new System.EventHandler(this.listOFCharStatLabel_Click);
            // 
            // extraTopLeftPanel
            // 
            this.extraTopLeftPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraTopLeftPanel.Location = new System.Drawing.Point(332, 411);
            this.extraTopLeftPanel.Name = "extraTopLeftPanel";
            this.extraTopLeftPanel.Size = new System.Drawing.Size(146, 100);
            this.extraTopLeftPanel.TabIndex = 4;
            this.extraTopLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraTopLeftPanel_Paint);
            // 
            // extraTopRightPanel
            // 
            this.extraTopRightPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraTopRightPanel.Location = new System.Drawing.Point(485, 411);
            this.extraTopRightPanel.Name = "extraTopRightPanel";
            this.extraTopRightPanel.Size = new System.Drawing.Size(146, 100);
            this.extraTopRightPanel.TabIndex = 5;
            this.extraTopRightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraTopRightPanel_Paint);
            // 
            // extraMiddlePAnel
            // 
            this.extraMiddlePAnel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraMiddlePAnel.Location = new System.Drawing.Point(332, 533);
            this.extraMiddlePAnel.Name = "extraMiddlePAnel";
            this.extraMiddlePAnel.Size = new System.Drawing.Size(299, 109);
            this.extraMiddlePAnel.TabIndex = 6;
            this.extraMiddlePAnel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraMiddlePAnel_Paint);
            // 
            // extraBottomPanel
            // 
            this.extraBottomPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraBottomPanel.Location = new System.Drawing.Point(332, 662);
            this.extraBottomPanel.Name = "extraBottomPanel";
            this.extraBottomPanel.Size = new System.Drawing.Size(299, 100);
            this.extraBottomPanel.TabIndex = 7;
            this.extraBottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraBottomPanel_Paint);
            // 
            // CharacterInfoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 774);
            this.Controls.Add(this.extraBottomPanel);
            this.Controls.Add(this.extraMiddlePAnel);
            this.Controls.Add(this.extraTopRightPanel);
            this.Controls.Add(this.extraTopLeftPanel);
            this.Controls.Add(this.listOfCharStatsPanel);
            this.Controls.Add(this.playerImagePanel);
            this.Controls.Add(this.charNameLAbel);
            this.Controls.Add(this.returnToOptions);
            this.Name = "CharacterInfoGui";
            this.Text = "CharacterInfoGui";
            this.playerImagePanel.ResumeLayout(false);
            this.playerImagePanel.PerformLayout();
            this.listOfCharStatsPanel.ResumeLayout(false);
            this.listOfCharStatsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToOptions;
        private System.Windows.Forms.Label charNameLAbel;
        private System.Windows.Forms.Panel playerImagePanel;
        private System.Windows.Forms.Label playerImageLabel;
        private System.Windows.Forms.Panel listOfCharStatsPanel;
        private System.Windows.Forms.Label listOFCharStatLabel;
        private System.Windows.Forms.Panel extraTopLeftPanel;
        private System.Windows.Forms.Panel extraTopRightPanel;
        private System.Windows.Forms.Panel extraMiddlePAnel;
        private System.Windows.Forms.Panel extraBottomPanel;
    }
}