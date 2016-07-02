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
    public partial class CraftingGui : Form
    {
        public CraftingGui()
        {
            InitializeComponent();
        }

        private void CraftingGui_Load(object sender, EventArgs e)
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
            SpellsGui spellGui = new SpellsGui();
            spellGui.Show();
            this.Close();
        }

        private void craftingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OptionMenuGui optionMenuGui = new OptionMenuGui();
            optionMenuGui.Show();
            this.Close();
            //takes us back to the the original screen
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

        private void alchemyButton_Click(object sender, EventArgs e)
        {

        }

        private void blacksmithingButton_Click(object sender, EventArgs e)
        {

        }

        private void tailoringButton_Click(object sender, EventArgs e)
        {

        }

        private void leatherWorkingButton_Click(object sender, EventArgs e)
        {

        }

        private void woodCraftButton_Click(object sender, EventArgs e)
        {

        }

        private void experimentButton_Click(object sender, EventArgs e)
        {

        }

        private void filteringOptionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enchantmentButton_Click(object sender, EventArgs e)
        {

        }

        private void listOfRecipesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOfRecipesLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipeImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectedRecipeInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectedRecipesInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void craftRecipeButton_Click(object sender, EventArgs e)
        {

        }

        private void aquireIngrediantsButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
