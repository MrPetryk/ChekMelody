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
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Wiktorina.i++;
            WMP.URL = Wiktorina.list[Wiktorina.i];
        }
    }
}
