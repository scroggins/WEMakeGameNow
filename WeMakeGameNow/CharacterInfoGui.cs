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
    }
}
