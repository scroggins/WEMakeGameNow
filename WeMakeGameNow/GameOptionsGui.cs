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
    public partial class GameOptionsGui: Form
    {
        public GameOptionsGui()
        {
            InitializeComponent();
        }

        private void GameOptionsGui_Load(object sender, EventArgs e)
        {

        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterInfoGui charInfoGui = new CharacterInfoGui();
            charInfoGui.Show();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryGui inventoryGui = new InventoryGui();
            inventoryGui.Show();
            this.Close();
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpellsGui spellGui = new SpellsGui();
            spellGui.Show();
            this.Close();
        }

        private void craftingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CraftingGui craftingGui = new CraftingGui();
            craftingGui.Show();
            this.Close();
        }

        private void gameOptionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionMenuGui = new OptionMenuGui();
            optionMenuGui.Show();
            this.Close();
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

        private void soundLable_Click(object sender, EventArgs e)
        {

        }

        private void soundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlsLabel_Click(object sender, EventArgs e)
        {

        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void interfaceVideoLabel_Click(object sender, EventArgs e)
        {

        }

        private void interfaceVideoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
