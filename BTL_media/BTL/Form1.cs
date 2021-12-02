using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vitri = -1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                playlist.Items.Clear();
                playlist.Items.Add(openFileDialog1.FileName);
                vitri = 0;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ds = 0;
            if (playlist.Items.Count == 0)
            {
                ds = 1;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    foreach (String music in openFileDialog2.FileNames)
                    {
                        playlist.Items.Add(music);
                    }
                }
                if (axWindowsMediaPlayer1.status.Contains("Stop"))
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                if (ds != 0)
                {
                    axWindowsMediaPlayer1.URL = playlist.Items[0].ToString();
                }

            }
        }

        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitri = playlist.SelectedIndex;
            axWindowsMediaPlayer1.URL = playlist.Items[vitri].ToString();
        }
    }
    }


