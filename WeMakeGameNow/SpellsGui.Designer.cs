namespace WeMakeGameNow
{
    partial class SpellsGui
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
            this.spellFilteringOptionsPanel = new System.Windows.Forms.Panel();
            this.spellFilteringOptionLabel = new System.Windows.Forms.Label();
            this.spellListBox = new System.Windows.Forms.ListBox();
            this.spellListLabel = new System.Windows.Forms.Label();
            this.makeSpellLabel = new System.Windows.Forms.Label();
            this.makeSpellsListBox = new System.Windows.Forms.ListBox();
            this.spellListPanel = new System.Windows.Forms.Panel();
            this.listOfSpellsLabel = new System.Windows.Forms.Label();
            this.selectedSpellInfoPanel = new System.Windows.Forms.Panel();
            this.selectedSpellInfoLabel = new System.Windows.Forms.Label();
            this.equipSpellButton = new System.Windows.Forms.Button();
            this.useSpellButton = new System.Windows.Forms.Button();
            this.returnToTitleButton = new System.Windows.Forms.Button();
            this.backToGameButton = new System.Windows.Forms.Button();
            this.craftingButton = new System.Windows.Forms.Button();
            this.gameOptionsButton = new System.Windows.Forms.Button();
            this.spellsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.characterButton = new System.Windows.Forms.Button();
            this.spellFilteringOptionsPanel.SuspendLayout();
            this.spellListPanel.SuspendLayout();
            this.selectedSpellInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spellFilteringOptionsPanel
            // 
            this.spellFilteringOptionsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellFilteringOptionsPanel.Controls.Add(this.spellFilteringOptionLabel);
            this.spellFilteringOptionsPanel.Location = new System.Drawing.Point(191, 84);
            this.spellFilteringOptionsPanel.Name = "spellFilteringOptionsPanel";
            this.spellFilteringOptionsPanel.Size = new System.Drawing.Size(820, 51);
            this.spellFilteringOptionsPanel.TabIndex = 22;
            // 
            // spellFilteringOptionLabel
            // 
            this.spellFilteringOptionLabel.AutoSize = true;
            this.spellFilteringOptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellFilteringOptionLabel.Location = new System.Drawing.Point(191, 16);
            this.spellFilteringOptionLabel.Name = "spellFilteringOptionLabel";
            this.spellFilteringOptionLabel.Size = new System.Drawing.Size(354, 25);
            this.spellFilteringOptionLabel.TabIndex = 0;
            this.spellFilteringOptionLabel.Text = "Various Spell Filtering Options Here";
            this.spellFilteringOptionLabel.Click += new System.EventHandler(this.spellFilteringOptionLabel_Click);
            // 
            // spellListBox
            // 
            this.spellListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.spellListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellListBox.FormattingEnabled = true;
            this.spellListBox.ItemHeight = 25;
            this.spellListBox.Location = new System.Drawing.Point(194, 49);
            this.spellListBox.Name = "spellListBox";
            this.spellListBox.Size = new System.Drawing.Size(128, 29);
            this.spellListBox.TabIndex = 23;
            this.spellListBox.SelectedIndexChanged += new System.EventHandler(this.spellListBox_SelectedIndexChanged);
            // 
            // spellListLabel
            // 
            this.spellListLabel.AutoSize = true;
            this.spellListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellListLabel.Location = new System.Drawing.Point(199, 21);
            this.spellListLabel.Name = "spellListLabel";
            this.spellListLabel.Size = new System.Drawing.Size(100, 25);
            this.spellListLabel.TabIndex = 24;
            this.spellListLabel.Text = "Spell List";
            this.spellListLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.spellListLabel.Click += new System.EventHandler(this.spellListLabel_Click);
            // 
            // makeSpellLabel
            // 
            this.makeSpellLabel.AutoSize = true;
            this.makeSpellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeSpellLabel.Location = new System.Drawing.Point(400, 21);
            this.makeSpellLabel.Name = "makeSpellLabel";
            this.makeSpellLabel.Size = new System.Drawing.Size(130, 25);
            this.makeSpellLabel.TabIndex = 26;
            this.makeSpellLabel.Text = "Make Spells";
            this.makeSpellLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.makeSpellLabel.Click += new System.EventHandler(this.makeSpellLabel_Click);
            // 
            // makeSpellsListBox
            // 
            this.makeSpellsListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.makeSpellsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeSpellsListBox.FormattingEnabled = true;
            this.makeSpellsListBox.ItemHeight = 25;
            this.makeSpellsListBox.Location = new System.Drawing.Point(402, 49);
            this.makeSpellsListBox.Name = "makeSpellsListBox";
            this.makeSpellsListBox.Size = new System.Drawing.Size(128, 29);
            this.makeSpellsListBox.TabIndex = 25;
            this.makeSpellsListBox.SelectedIndexChanged += new System.EventHandler(this.makeSpellsListBox_SelectedIndexChanged);
            // 
            // spellListPanel
            // 
            this.spellListPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellListPanel.Controls.Add(this.listOfSpellsLabel);
            this.spellListPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellListPanel.Location = new System.Drawing.Point(204, 141);
            this.spellListPanel.Name = "spellListPanel";
            this.spellListPanel.Size = new System.Drawing.Size(354, 579);
            this.spellListPanel.TabIndex = 27;
            this.spellListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spellListPanel_Paint);
            // 
            // listOfSpellsLabel
            // 
            this.listOfSpellsLabel.AutoSize = true;
            this.listOfSpellsLabel.Location = new System.Drawing.Point(36, 183);
            this.listOfSpellsLabel.Name = "listOfSpellsLabel";
            this.listOfSpellsLabel.Size = new System.Drawing.Size(139, 25);
            this.listOfSpellsLabel.TabIndex = 0;
            this.listOfSpellsLabel.Text = "List Of Spells";
            this.listOfSpellsLabel.Click += new System.EventHandler(this.listOfSpellsLabel_Click);
            // 
            // selectedSpellInfoPanel
            // 
            this.selectedSpellInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectedSpellInfoPanel.Controls.Add(this.selectedSpellInfoLabel);
            this.selectedSpellInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSpellInfoPanel.Location = new System.Drawing.Point(576, 144);
            this.selectedSpellInfoPanel.Name = "selectedSpellInfoPanel";
            this.selectedSpellInfoPanel.Size = new System.Drawing.Size(435, 316);
            this.selectedSpellInfoPanel.TabIndex = 28;
            this.selectedSpellInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedSpellInfoPanel_Paint);
            // 
            // selectedSpellInfoLabel
            // 
            this.selectedSpellInfoLabel.AutoSize = true;
            this.selectedSpellInfoLabel.Location = new System.Drawing.Point(103, 143);
            this.selectedSpellInfoLabel.Name = "selectedSpellInfoLabel";
            this.selectedSpellInfoLabel.Size = new System.Drawing.Size(191, 25);
            this.selectedSpellInfoLabel.TabIndex = 0;
            this.selectedSpellInfoLabel.Text = "Selected Spell Info";
            this.selectedSpellInfoLabel.Click += new System.EventHandler(this.selectedSpellInfoLabel_Click);
            // 
            // equipSpellButton
            // 
            this.equipSpellButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equipSpellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipSpellButton.Location = new System.Drawing.Point(813, 483);
            this.equipSpellButton.Name = "equipSpellButton";
            this.equipSpellButton.Size = new System.Drawing.Size(198, 74);
            this.equipSpellButton.TabIndex = 30;
            this.equipSpellButton.Text = "Equip Spell";
            this.equipSpellButton.UseVisualStyleBackColor = false;
            this.equipSpellButton.Click += new System.EventHandler(this.equipSpellButton_Click);
            // 
            // useSpellButton
            // 
            this.useSpellButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.useSpellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useSpellButton.Location = new System.Drawing.Point(576, 483);
            this.useSpellButton.Name = "useSpellButton";
            this.useSpellButton.Size = new System.Drawing.Size(198, 74);
            this.useSpellButton.TabIndex = 31;
            this.useSpellButton.Text = "Use Spell";
            this.useSpellButton.UseVisualStyleBackColor = false;
            this.useSpellButton.Click += new System.EventHandler(this.useSpellButton_Click);
            // 
            // returnToTitleButton
            // 
            this.returnToTitleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnToTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnToTitleButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToTitleButton.Location = new System.Drawing.Point(12, 645);
            this.returnToTitleButton.Name = "returnToTitleButton";
            this.returnToTitleButton.Size = new System.Drawing.Size(157, 98);
            this.returnToTitleButton.TabIndex = 38;
            this.returnToTitleButton.Text = "Return To Title";
            this.returnToTitleButton.UseVisualStyleBackColor = false;
            // 
            // backToGameButton
            // 
            this.backToGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backToGameButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToGameButton.Location = new System.Drawing.Point(12, 541);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(157, 98);
            this.backToGameButton.TabIndex = 37;
            this.backToGameButton.Text = "Back To Game (ESC)";
            this.backToGameButton.UseVisualStyleBackColor = false;
            // 
            // craftingButton
            // 
            this.craftingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.craftingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.craftingButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftingButton.Location = new System.Drawing.Point(12, 333);
            this.craftingButton.Name = "craftingButton";
            this.craftingButton.Size = new System.Drawing.Size(157, 98);
            this.craftingButton.TabIndex = 35;
            this.craftingButton.Text = "Crafting";
            this.craftingButton.UseVisualStyleBackColor = false;
            // 
            // gameOptionsButton
            // 
            this.gameOptionsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOptionsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOptionsButton.Location = new System.Drawing.Point(12, 437);
            this.gameOptionsButton.Name = "gameOptionsButton";
            this.gameOptionsButton.Size = new System.Drawing.Size(157, 98);
            this.gameOptionsButton.TabIndex = 36;
            this.gameOptionsButton.Text = "Game Options";
            this.gameOptionsButton.UseVisualStyleBackColor = false;
            // 
            // spellsButton
            // 
            this.spellsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spellsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellsButton.Location = new System.Drawing.Point(12, 229);
            this.spellsButton.Name = "spellsButton";
            this.spellsButton.Size = new System.Drawing.Size(157, 98);
            this.spellsButton.TabIndex = 34;
            this.spellsButton.Text = "Spells";
            this.spellsButton.UseVisualStyleBackColor = false;
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(12, 125);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(157, 98);
            this.inventoryButton.TabIndex = 33;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            // 
            // characterButton
            // 
            this.characterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterButton.Location = new System.Drawing.Point(12, 21);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(157, 98);
            this.characterButton.TabIndex = 32;
            this.characterButton.Text = "Character Info";
            this.characterButton.UseVisualStyleBackColor = false;
            // 
            // SpellsGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 794);
            this.Controls.Add(this.returnToTitleButton);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.craftingButton);
            this.Controls.Add(this.gameOptionsButton);
            this.Controls.Add(this.spellsButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.characterButton);
            this.Controls.Add(this.useSpellButton);
            this.Controls.Add(this.equipSpellButton);
            this.Controls.Add(this.selectedSpellInfoPanel);
            this.Controls.Add(this.spellListPanel);
            this.Controls.Add(this.makeSpellLabel);
            this.Controls.Add(this.makeSpellsListBox);
            this.Controls.Add(this.spellListLabel);
            this.Controls.Add(this.spellListBox);
            this.Controls.Add(this.spellFilteringOptionsPanel);
            this.Name = "SpellsGui";
            this.Text = "SpellsGui";
            this.Load += new System.EventHandler(this.SpellsGui_Load);
            this.spellFilteringOptionsPanel.ResumeLayout(false);
            this.spellFilteringOptionsPanel.PerformLayout();
            this.spellListPanel.ResumeLayout(false);
            this.spellListPanel.PerformLayout();
            this.selectedSpellInfoPanel.ResumeLayout(false);
            this.selectedSpellInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel spellFilteringOptionsPanel;
        private System.Windows.Forms.Label spellFilteringOptionLabel;
        private System.Windows.Forms.ListBox spellListBox;
        private System.Windows.Forms.Label spellListLabel;
        private System.Windows.Forms.Label makeSpellLabel;
        private System.Windows.Forms.ListBox makeSpellsListBox;
        private System.Windows.Forms.Panel spellListPanel;
        private System.Windows.Forms.Label listOfSpellsLabel;
        private System.Windows.Forms.Panel selectedSpellInfoPanel;
        private System.Windows.Forms.Label selectedSpellInfoLabel;
        private System.Windows.Forms.Button equipSpellButton;
        private System.Windows.Forms.Button useSpellButton;
        private System.Windows.Forms.Button returnToTitleButton;
        private System.Windows.Forms.Button backToGameButton;
        private System.Windows.Forms.Button craftingButton;
        private System.Windows.Forms.Button gameOptionsButton;
        private System.Windows.Forms.Button spellsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button characterButton;
    }
}