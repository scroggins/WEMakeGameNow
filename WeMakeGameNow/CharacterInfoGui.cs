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
    public partial class CharacterInfoGui : Form
    {
        public CharacterInfoGui()
        {
            InitializeComponent();
        }

        private void charNameLAbel_Click(object sender, EventArgs e)
        {

        }

        private void returnToOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionGui = new OptionMenuGui();
            optionGui.Show();
        }

        private void playerImagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOFCharStatLabel_Click(object sender, EventArgs e)
        {

        }

        private void extraTopLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extraTopRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extraMiddlePAnel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extraBottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOfCharStatsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void playerImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionGui = new OptionMenuGui();
            optionGui.Show();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryGui inventoryGui = new InventoryGui();
            inventoryGui.Show();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
