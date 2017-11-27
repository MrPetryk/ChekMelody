using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChekMeldy
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
           
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionsForm of = new optionsForm();
            of.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Wiktorina.readParameters();
            Wiktorina.readMusic();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            gameForm gf = new gameForm();
            gf.ShowDialog();
        }
    }
}
