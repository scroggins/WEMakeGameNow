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
    public partial class OptionMenuGui : Form
    {
        public OptionMenuGui()
        {
            InitializeComponent();
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterInfoGui charInfoGui = new CharacterInfoGui();
            charInfoGui.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryGui inventoryGui = new InventoryGui();
            inventoryGui.Show();
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {
            SpellsGui spellGui = new SpellsGui();
        }

        private void craftingButton_Click(object sender, EventArgs e)
        {
            CraftingGui craftingGui = new CraftingGui();
        }

        private void gameOptionsButton_Click(object sender, EventArgs e)
        {
            GameOptionsGui gameOptionsGui = new GameOptionsGui();
        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {

        }

        private void returnToTitleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
