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
            this.charNameLAbel = new System.Windows.Forms.Label();
            this.playerImagePanel = new System.Windows.Forms.Panel();
            this.playerImageLabel = new System.Windows.Forms.Label();
            this.listOfCharStatsPanel = new System.Windows.Forms.Panel();
            this.listOFCharStatLabel = new System.Windows.Forms.Label();
            this.extraMiddlePAnel = new System.Windows.Forms.Panel();
            this.extraBottomPanel = new System.Windows.Forms.Panel();
            this.returnToTitleButton = new System.Windows.Forms.Button();
            this.backToGameButton = new System.Windows.Forms.Button();
            this.craftingButton = new System.Windows.Forms.Button();
            this.gameOptionsButton = new System.Windows.Forms.Button();
            this.spellsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.characterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerImagePanel.SuspendLayout();
            this.listOfCharStatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // charNameLAbel
            // 
            this.charNameLAbel.AutoSize = true;
            this.charNameLAbel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charNameLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameLAbel.Location = new System.Drawing.Point(208, 36);
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
            this.playerImagePanel.Location = new System.Drawing.Point(187, 85);
            this.playerImagePanel.Name = "playerImagePanel";
            this.playerImagePanel.Size = new System.Drawing.Size(389, 677);
            this.playerImagePanel.TabIndex = 2;
            this.playerImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerImagePanel_Paint);
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
            // listOfCharStatsPanel
            // 
            this.listOfCharStatsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listOfCharStatsPanel.Controls.Add(this.listOFCharStatLabel);
            this.listOfCharStatsPanel.Location = new System.Drawing.Point(582, 85);
            this.listOfCharStatsPanel.Name = "listOfCharStatsPanel";
            this.listOfCharStatsPanel.Size = new System.Drawing.Size(472, 320);
            this.listOfCharStatsPanel.TabIndex = 3;
            this.listOfCharStatsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.listOfCharStatsPanel_Paint);
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
            // extraMiddlePAnel
            // 
            this.extraMiddlePAnel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraMiddlePAnel.Location = new System.Drawing.Point(582, 533);
            this.extraMiddlePAnel.Name = "extraMiddlePAnel";
            this.extraMiddlePAnel.Size = new System.Drawing.Size(472, 109);
            this.extraMiddlePAnel.TabIndex = 6;
            this.extraMiddlePAnel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraMiddlePAnel_Paint);
            // 
            // extraBottomPanel
            // 
            this.extraBottomPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.extraBottomPanel.Location = new System.Drawing.Point(582, 662);
            this.extraBottomPanel.Name = "extraBottomPanel";
            this.extraBottomPanel.Size = new System.Drawing.Size(472, 100);
            this.extraBottomPanel.TabIndex = 7;
            this.extraBottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.extraBottomPanel_Paint);
            // 
            // returnToTitleButton
            // 
            this.returnToTitleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnToTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnToTitleButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToTitleButton.Location = new System.Drawing.Point(12, 636);
            this.returnToTitleButton.Name = "returnToTitleButton";
            this.returnToTitleButton.Size = new System.Drawing.Size(157, 98);
            this.returnToTitleButton.TabIndex = 14;
            this.returnToTitleButton.Text = "Return To Title";
            this.returnToTitleButton.UseVisualStyleBackColor = false;
            this.returnToTitleButton.Click += new System.EventHandler(this.returnToTitleButton_Click);
            // 
            // backToGameButton
            // 
            this.backToGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backToGameButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToGameButton.Location = new System.Drawing.Point(12, 532);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(157, 98);
            this.backToGameButton.TabIndex = 13;
            this.backToGameButton.Text = "Back To Game (ESC)";
            this.backToGameButton.UseVisualStyleBackColor = false;
            this.backToGameButton.Click += new System.EventHandler(this.backToGameButton_Click);
            // 
            // craftingButton
            // 
            this.craftingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.craftingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.craftingButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftingButton.Location = new System.Drawing.Point(12, 324);
            this.craftingButton.Name = "craftingButton";
            this.craftingButton.Size = new System.Drawing.Size(157, 98);
            this.craftingButton.TabIndex = 11;
            this.craftingButton.Text = "Crafting";
            this.craftingButton.UseVisualStyleBackColor = false;
            this.craftingButton.Click += new System.EventHandler(this.craftingButton_Click);
            // 
            // gameOptionsButton
            // 
            this.gameOptionsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOptionsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOptionsButton.Location = new System.Drawing.Point(12, 428);
            this.gameOptionsButton.Name = "gameOptionsButton";
            this.gameOptionsButton.Size = new System.Drawing.Size(157, 98);
            this.gameOptionsButton.TabIndex = 12;
            this.gameOptionsButton.Text = "Game Options";
            this.gameOptionsButton.UseVisualStyleBackColor = false;
            this.gameOptionsButton.Click += new System.EventHandler(this.gameOptionsButton_Click);
            // 
            // spellsButton
            // 
            this.spellsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spellsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellsButton.Location = new System.Drawing.Point(12, 220);
            this.spellsButton.Name = "spellsButton";
            this.spellsButton.Size = new System.Drawing.Size(157, 98);
            this.spellsButton.TabIndex = 10;
            this.spellsButton.Text = "Spells";
            this.spellsButton.UseVisualStyleBackColor = false;
            this.spellsButton.Click += new System.EventHandler(this.spellsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(12, 116);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(157, 98);
            this.inventoryButton.TabIndex = 9;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // characterButton
            // 
            this.characterButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterButton.Location = new System.Drawing.Point(12, 12);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(157, 98);
            this.characterButton.TabIndex = 8;
            this.characterButton.Text = "Character Info";
            this.characterButton.UseVisualStyleBackColor = false;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(582, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 100);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(829, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CharacterInfoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.returnToTitleButton);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.craftingButton);
            this.Controls.Add(this.gameOptionsButton);
            this.Controls.Add(this.spellsButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.characterButton);
            this.Controls.Add(this.extraBottomPanel);
            this.Controls.Add(this.extraMiddlePAnel);
            this.Controls.Add(this.listOfCharStatsPanel);
            this.Controls.Add(this.playerImagePanel);
            this.Controls.Add(this.charNameLAbel);
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
        private System.Windows.Forms.Label charNameLAbel;
        private System.Windows.Forms.Panel playerImagePanel;
        private System.Windows.Forms.Label playerImageLabel;
        private System.Windows.Forms.Panel listOfCharStatsPanel;
        private System.Windows.Forms.Label listOFCharStatLabel;
        private System.Windows.Forms.Panel extraMiddlePAnel;
        private System.Windows.Forms.Panel extraBottomPanel;
        private System.Windows.Forms.Button returnToTitleButton;
        private System.Windows.Forms.Button backToGameButton;
        private System.Windows.Forms.Button craftingButton;
        private System.Windows.Forms.Button gameOptionsButton;
        private System.Windows.Forms.Button spellsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}