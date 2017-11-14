using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        string[] files, paths;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_durasi.Text = player.currentMedia.durationString;
            text_posisi.Text = player.Ctlcontrols.currentPositionString;
            trackBar1.Maximum = Convert.ToInt16(player.currentMedia.duration);
            trackBar1.Value = Convert.ToInt16(player.Ctlcontrols.currentPosition);
            if (player.Ctlcontrols.currentPositionString == player.currentMedia.durationString)
            {
                if (listMusic.SelectedIndex != listMusic.Items.Count - 1)
                {
                    listMusic.SetSelected(listMusic.SelectedIndex + 1, true);
                    player.URL = paths[listMusic.SelectedIndex];
                    text_judul.Text = listMusic.Text;
                }
            }
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[listMusic.SelectedIndex];
            timer1.Start();
            text_judul.Text = listMusic.Text;
            
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            player.URL = paths[listMusic.SelectedIndex];
            timer1.Start();
            text_judul.Text = listMusic.Text;
            
        }

        private void pb_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            player.Ctlcontrols.currentPosition = Convert.ToDouble(text_posisi.Text.Replace(":", ""));
        }

        private void pb_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void pb_first_Click(object sender, EventArgs e)
        {
            listMusic.SetSelected(0, true);
            player.URL = paths[listMusic.SelectedIndex];
            text_judul.Text = listMusic.Text;
        }

        private void pb_prev_Click(object sender, EventArgs e)
        {
            if(listMusic.SelectedIndex != 0)
            {
                listMusic.SetSelected(listMusic.SelectedIndex - 1, true);
                player.URL = paths[listMusic.SelectedIndex];
                text_judul.Text = listMusic.Text;
            }
        }

        private void pb_next_Click(object sender, EventArgs e)
        {
            if(listMusic.SelectedIndex != listMusic.Items.Count -1)
            {
                listMusic.SetSelected(listMusic.SelectedIndex + 1, true);
                player.URL = paths[listMusic.SelectedIndex];
                text_judul.Text = listMusic.Text;
            }
        }

        private void pb_last_Click(object sender, EventArgs e)
        {
            listMusic.SetSelected(listMusic.Items.Count - 1, true);
            player.URL = paths[listMusic.SelectedIndex];
            text_judul.Text = listMusic.Text;
        }

        private void pb_volume_Click(object sender, EventArgs e)
        {
            player.settings.volume = tb_volume.Value;
            timer1.Start();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = open.SafeFileNames;
                paths = open.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    listMusic.Items.Add(files[i]);
                }
            }
        }
    }
}
