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
    public partial class SpellsGui : Form
    {
        public SpellsGui()
        {
            InitializeComponent();
        }

        private void SpellsGui_Load(object sender, EventArgs e)
        {

        }

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
            OptionMenuGui optionMenu = new OptionMenuGui();
            optionMenu.Show();
            this.Close();
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionMenuGui = new OptionMenuGui();
            optionMenuGui.Show();
            this.Close();
            //takes us back to the the original screen
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

        private void spellListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spellListLabel_Click(object sender, EventArgs e)
        {

        }

        private void makeSpellLabel_Click(object sender, EventArgs e)
        {

        }

        private void makeSpellsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spellFilteringOptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void spellListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOfSpellsLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectedSpellInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectedSpellInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void useSpellButton_Click(object sender, EventArgs e)
        {

        }

        private void equipSpellButton_Click(object sender, EventArgs e)
        {

        }
    }
}
