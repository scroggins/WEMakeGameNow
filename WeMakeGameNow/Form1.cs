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
    public partial class OptionsGui : Form
    {
        public OptionsGui()
        {
            InitializeComponent();
        }

        private void characterButton_Click(object sender, EventArgs e)
        {

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryGui inventoryGui = new InventoryGui();
            inventoryGui.Show();
        }

        private void spellsButton_Click(object sender, EventArgs e)
        {

        }

        private void craftingButton_Click(object sender, EventArgs e)
        {

        }

        private void gameOptionsButton_Click(object sender, EventArgs e)
        {

        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {

        }

        private void returnToTitleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
