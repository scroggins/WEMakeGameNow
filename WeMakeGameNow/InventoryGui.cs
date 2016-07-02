using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeMakeGameNow
{
    public partial class InventoryGui : Form
    {
        public InventoryGui()
        {
            InitializeComponent();
        }

        private void filterOptionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterOptionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listItemsLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectedItemInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dropItemButton_Click(object sender, EventArgs e)
        {

        }

        private void craftWithItemButton_Click(object sender, EventArgs e)
        {

        }

        private void equipItemButton_Click(object sender, EventArgs e)
        {

        }

        private void useItemButton_Click(object sender, EventArgs e)
        {

        }

        private void selectedItemInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void InventoryGui_Load(object sender, EventArgs e)
        {

        }
        /*  Killed this button off
        private void returnToOptionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionsMenu = new OptionMenuGui();
            optionsMenu.Show(); 
        }*/

        private void characterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterInfoGui charGui = new CharacterInfoGui();
            charGui.Show();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionMenuGui = new OptionMenuGui();
            optionMenuGui.Show();
            this.Close();
            //takes us back to the the original screen
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpellsGui spellGui = new SpellsGui();
            spellGui.Show();
        }

        private void craftingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CraftingGui craftingGui = new CraftingGui();
            craftingGui.Show();
        }

        private void gameOptionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameOptionsGui gameOptionsGui = new GameOptionsGui();
            gameOptionsGui.Show();
        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {
            //need to return to game and close this gui 
            this.Close();
        }

        private void returnToTitleButton_Click(object sender, EventArgs e)
        {
            //need a title to return to
        }
    }
}
