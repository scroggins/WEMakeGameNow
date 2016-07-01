namespace WeMakeGameNow
{
    partial class OptionMenuGui
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
            this.characterButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.spellsButton = new System.Windows.Forms.Button();
            this.gameOptionsButton = new System.Windows.Forms.Button();
            this.craftingButton = new System.Windows.Forms.Button();
            this.backToGameButton = new System.Windows.Forms.Button();
            this.returnToTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // characterButton
            // 
            this.characterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterButton.Location = new System.Drawing.Point(0, 12);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(157, 98);
            this.characterButton.TabIndex = 0;
            this.characterButton.TabStop = false;
            this.characterButton.Text = "Character Info";
            this.characterButton.UseVisualStyleBackColor = false;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryButton.Location = new System.Drawing.Point(0, 116);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(157, 98);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // spellsButton
            // 
            this.spellsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spellsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spellsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellsButton.Location = new System.Drawing.Point(0, 220);
            this.spellsButton.Name = "spellsButton";
            this.spellsButton.Size = new System.Drawing.Size(157, 98);
            this.spellsButton.TabIndex = 2;
            this.spellsButton.Text = "Spells";
            this.spellsButton.UseVisualStyleBackColor = false;
            this.spellsButton.Click += new System.EventHandler(this.spellsButton_Click);
            // 
            // gameOptionsButton
            // 
            this.gameOptionsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOptionsButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOptionsButton.Location = new System.Drawing.Point(0, 428);
            this.gameOptionsButton.Name = "gameOptionsButton";
            this.gameOptionsButton.Size = new System.Drawing.Size(157, 98);
            this.gameOptionsButton.TabIndex = 3;
            this.gameOptionsButton.Text = "Game Options";
            this.gameOptionsButton.UseVisualStyleBackColor = false;
            this.gameOptionsButton.Click += new System.EventHandler(this.gameOptionsButton_Click);
            // 
            // craftingButton
            // 
            this.craftingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.craftingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.craftingButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftingButton.Location = new System.Drawing.Point(0, 324);
            this.craftingButton.Name = "craftingButton";
            this.craftingButton.Size = new System.Drawing.Size(157, 98);
            this.craftingButton.TabIndex = 4;
            this.craftingButton.Text = "Crafting";
            this.craftingButton.UseVisualStyleBackColor = false;
            this.craftingButton.Click += new System.EventHandler(this.craftingButton_Click);
            // 
            // backToGameButton
            // 
            this.backToGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backToGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backToGameButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToGameButton.Location = new System.Drawing.Point(0, 532);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(157, 98);
            this.backToGameButton.TabIndex = 5;
            this.backToGameButton.Text = "Back To Game (ESC)";
            this.backToGameButton.UseVisualStyleBackColor = false;
            this.backToGameButton.Click += new System.EventHandler(this.backToGameButton_Click);
            // 
            // returnToTitleButton
            // 
            this.returnToTitleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnToTitleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnToTitleButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToTitleButton.Location = new System.Drawing.Point(0, 636);
            this.returnToTitleButton.Name = "returnToTitleButton";
            this.returnToTitleButton.Size = new System.Drawing.Size(157, 98);
            this.returnToTitleButton.TabIndex = 6;
            this.returnToTitleButton.Text = "Return To Title";
            this.returnToTitleButton.UseVisualStyleBackColor = false;
            this.returnToTitleButton.Click += new System.EventHandler(this.returnToTitleButton_Click);
            // 
            // OptionMenuGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 811);
            this.Controls.Add(this.returnToTitleButton);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.craftingButton);
            this.Controls.Add(this.gameOptionsButton);
            this.Controls.Add(this.spellsButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.characterButton);
            this.Name = "OptionMenuGui";
            this.Text = "OptionMenuGui";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button spellsButton;
        private System.Windows.Forms.Button gameOptionsButton;
        private System.Windows.Forms.Button craftingButton;
        private System.Windows.Forms.Button backToGameButton;
        private System.Windows.Forms.Button returnToTitleButton;
    }
}

