namespace WeMakeGameNow
{
    partial class InventoryGui
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
            this.itemListPanel = new System.Windows.Forms.Panel();
            this.selectedItemInfoPanel = new System.Windows.Forms.Panel();
            this.itemImagePanel = new System.Windows.Forms.Panel();
            this.useItemButton = new System.Windows.Forms.Button();
            this.equipItemButton = new System.Windows.Forms.Button();
            this.craftWithItemButton = new System.Windows.Forms.Button();
            this.dropItemButton = new System.Windows.Forms.Button();
            this.filterOptionsPanel = new System.Windows.Forms.Panel();
            this.listItemsLabel = new System.Windows.Forms.Label();
            this.itemImageLabel = new System.Windows.Forms.Label();
            this.selectedItemInfoLabel = new System.Windows.Forms.Label();
            this.filterOptionsLabel = new System.Windows.Forms.Label();
            this.returnToOptionsButton = new System.Windows.Forms.Button();
            this.itemListPanel.SuspendLayout();
            this.selectedItemInfoPanel.SuspendLayout();
            this.itemImagePanel.SuspendLayout();
            this.filterOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListPanel
            // 
            this.itemListPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemListPanel.Controls.Add(this.listItemsLabel);
            this.itemListPanel.Location = new System.Drawing.Point(21, 67);
            this.itemListPanel.Name = "itemListPanel";
            this.itemListPanel.Size = new System.Drawing.Size(303, 680);
            this.itemListPanel.TabIndex = 0;
            this.itemListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.itemListPanel_Paint);
            // 
            // selectedItemInfoPanel
            // 
            this.selectedItemInfoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectedItemInfoPanel.Controls.Add(this.selectedItemInfoLabel);
            this.selectedItemInfoPanel.Controls.Add(this.itemImagePanel);
            this.selectedItemInfoPanel.Location = new System.Drawing.Point(330, 67);
            this.selectedItemInfoPanel.Name = "selectedItemInfoPanel";
            this.selectedItemInfoPanel.Size = new System.Drawing.Size(496, 322);
            this.selectedItemInfoPanel.TabIndex = 1;
            this.selectedItemInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectedItemInfoPanel_Paint);
            // 
            // itemImagePanel
            // 
            this.itemImagePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImagePanel.Controls.Add(this.itemImageLabel);
            this.itemImagePanel.Location = new System.Drawing.Point(12, 14);
            this.itemImagePanel.Name = "itemImagePanel";
            this.itemImagePanel.Size = new System.Drawing.Size(156, 148);
            this.itemImagePanel.TabIndex = 2;
            // 
            // useItemButton
            // 
            this.useItemButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.useItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useItemButton.Location = new System.Drawing.Point(330, 399);
            this.useItemButton.Name = "useItemButton";
            this.useItemButton.Size = new System.Drawing.Size(245, 115);
            this.useItemButton.TabIndex = 5;
            this.useItemButton.Text = "Use Item";
            this.useItemButton.UseVisualStyleBackColor = false;
            this.useItemButton.Click += new System.EventHandler(this.useItemButton_Click);
            // 
            // equipItemButton
            // 
            this.equipItemButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equipItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipItemButton.Location = new System.Drawing.Point(581, 399);
            this.equipItemButton.Name = "equipItemButton";
            this.equipItemButton.Size = new System.Drawing.Size(245, 115);
            this.equipItemButton.TabIndex = 6;
            this.equipItemButton.Text = "Equip Item";
            this.equipItemButton.UseVisualStyleBackColor = false;
            this.equipItemButton.Click += new System.EventHandler(this.equipItemButton_Click);
            // 
            // craftWithItemButton
            // 
            this.craftWithItemButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.craftWithItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftWithItemButton.Location = new System.Drawing.Point(330, 520);
            this.craftWithItemButton.Name = "craftWithItemButton";
            this.craftWithItemButton.Size = new System.Drawing.Size(496, 108);
            this.craftWithItemButton.TabIndex = 8;
            this.craftWithItemButton.Text = "Craft With Item (?)";
            this.craftWithItemButton.UseVisualStyleBackColor = false;
            this.craftWithItemButton.Click += new System.EventHandler(this.craftWithItemButton_Click);
            // 
            // dropItemButton
            // 
            this.dropItemButton.BackColor = System.Drawing.Color.Red;
            this.dropItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropItemButton.Location = new System.Drawing.Point(330, 634);
            this.dropItemButton.Name = "dropItemButton";
            this.dropItemButton.Size = new System.Drawing.Size(496, 113);
            this.dropItemButton.TabIndex = 9;
            this.dropItemButton.Text = "Drop Item (?)";
            this.dropItemButton.UseVisualStyleBackColor = false;
            this.dropItemButton.Click += new System.EventHandler(this.dropItemButton_Click);
            // 
            // filterOptionsPanel
            // 
            this.filterOptionsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filterOptionsPanel.Controls.Add(this.filterOptionsLabel);
            this.filterOptionsPanel.Location = new System.Drawing.Point(287, 6);
            this.filterOptionsPanel.Name = "filterOptionsPanel";
            this.filterOptionsPanel.Size = new System.Drawing.Size(544, 55);
            this.filterOptionsPanel.TabIndex = 10;
            this.filterOptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filterOptionsPanel_Paint);
            // 
            // listItemsLabel
            // 
            this.listItemsLabel.AutoSize = true;
            this.listItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemsLabel.Location = new System.Drawing.Point(22, 297);
            this.listItemsLabel.Name = "listItemsLabel";
            this.listItemsLabel.Size = new System.Drawing.Size(131, 25);
            this.listItemsLabel.TabIndex = 0;
            this.listItemsLabel.Text = "List Of Items";
            this.listItemsLabel.Click += new System.EventHandler(this.listItemsLabel_Click);
            // 
            // itemImageLabel
            // 
            this.itemImageLabel.AutoSize = true;
            this.itemImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemImageLabel.Location = new System.Drawing.Point(3, 54);
            this.itemImageLabel.Name = "itemImageLabel";
            this.itemImageLabel.Size = new System.Drawing.Size(116, 25);
            this.itemImageLabel.TabIndex = 0;
            this.itemImageLabel.Text = "Item Image";
            this.itemImageLabel.Click += new System.EventHandler(this.itemImageLabel_Click);
            // 
            // selectedItemInfoLabel
            // 
            this.selectedItemInfoLabel.AutoSize = true;
            this.selectedItemInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedItemInfoLabel.Location = new System.Drawing.Point(16, 183);
            this.selectedItemInfoLabel.Name = "selectedItemInfoLabel";
            this.selectedItemInfoLabel.Size = new System.Drawing.Size(183, 25);
            this.selectedItemInfoLabel.TabIndex = 3;
            this.selectedItemInfoLabel.Text = "Selected Item Info";
            this.selectedItemInfoLabel.Click += new System.EventHandler(this.selectedItemInfoLabel_Click);
            // 
            // filterOptionsLabel
            // 
            this.filterOptionsLabel.AutoSize = true;
            this.filterOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsLabel.Location = new System.Drawing.Point(27, 21);
            this.filterOptionsLabel.Name = "filterOptionsLabel";
            this.filterOptionsLabel.Size = new System.Drawing.Size(300, 25);
            this.filterOptionsLabel.TabIndex = 0;
            this.filterOptionsLabel.Text = "Various Filtering Options Here";
            this.filterOptionsLabel.Click += new System.EventHandler(this.filterOptionsLabel_Click);
            // 
            // returnToOptionsButton
            // 
            this.returnToOptionsButton.BackColor = System.Drawing.Color.Yellow;
            this.returnToOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToOptionsButton.Location = new System.Drawing.Point(21, 13);
            this.returnToOptionsButton.Name = "returnToOptionsButton";
            this.returnToOptionsButton.Size = new System.Drawing.Size(260, 48);
            this.returnToOptionsButton.TabIndex = 11;
            this.returnToOptionsButton.Text = "Options Menu";
            this.returnToOptionsButton.UseVisualStyleBackColor = false;
            this.returnToOptionsButton.Click += new System.EventHandler(this.returnToOptionsButton_Click);
            // 
            // InventoryGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 794);
            this.Controls.Add(this.returnToOptionsButton);
            this.Controls.Add(this.filterOptionsPanel);
            this.Controls.Add(this.dropItemButton);
            this.Controls.Add(this.craftWithItemButton);
            this.Controls.Add(this.equipItemButton);
            this.Controls.Add(this.useItemButton);
            this.Controls.Add(this.selectedItemInfoPanel);
            this.Controls.Add(this.itemListPanel);
            this.Name = "InventoryGui";
            this.Text = "InventoryGui";
            this.Load += new System.EventHandler(this.InventoryGui_Load);
            this.itemListPanel.ResumeLayout(false);
            this.itemListPanel.PerformLayout();
            this.selectedItemInfoPanel.ResumeLayout(false);
            this.selectedItemInfoPanel.PerformLayout();
            this.itemImagePanel.ResumeLayout(false);
            this.itemImagePanel.PerformLayout();
            this.filterOptionsPanel.ResumeLayout(false);
            this.filterOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itemListPanel;
        private System.Windows.Forms.Label listItemsLabel;
        private System.Windows.Forms.Panel selectedItemInfoPanel;
        private System.Windows.Forms.Label selectedItemInfoLabel;
        private System.Windows.Forms.Panel itemImagePanel;
        private System.Windows.Forms.Label itemImageLabel;
        private System.Windows.Forms.Button useItemButton;
        private System.Windows.Forms.Button equipItemButton;
        private System.Windows.Forms.Button craftWithItemButton;
        private System.Windows.Forms.Button dropItemButton;
        private System.Windows.Forms.Panel filterOptionsPanel;
        private System.Windows.Forms.Label filterOptionsLabel;
        private System.Windows.Forms.Button returnToOptionsButton;
    }
}