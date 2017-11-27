using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChekMeldy
{
    public partial class optionsForm : Form
    {
        public optionsForm()
        {

            InitializeComponent();
        }

        void setParameters()
        {
            musicTime.Text = Wiktorina.musicDuration.ToString();
            answerTime.Text = Wiktorina.gameDuration.ToString();
            chekPosition.Checked = Wiktorina.randomStart;
            checkFlderInside.Checked = Wiktorina.allDirectories;
            songsList.Items.AddRange(Wiktorina.list.ToArray());
            
        }

        private void optionsForm_Load(object sender, EventArgs e)
        {
            Wiktorina.readParameters();
            setParameters();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Wiktorina.musicDuration = Convert.ToInt32(musicTime.Text);
            Wiktorina.gameDuration = Convert.ToInt32(answerTime.Text);
            Wiktorina.randomStart = Convert.ToBoolean(chekPosition.Checked);
            Wiktorina.allDirectories = Convert.ToBoolean(checkFlderInside.Checked);
            Wiktorina.writeParameters();
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addSongsButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", checkFlderInside.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                songsList.Items.AddRange(musicList);
                Wiktorina.list.AddRange(musicList);
                Wiktorina.lastFolder = fbd.SelectedPath;
            }
            
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            songsList.Items.Clear();
            Wiktorina.list.Clear();
        }
    }
}
