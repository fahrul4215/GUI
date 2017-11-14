using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaPlayer
{
    public partial class Form1 : Form
    {
        string[] files, paths;

        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            text_durasi.Text = Player.currentMedia.durationString;
            text_posisi.Text = Player.Ctlcontrols.currentPositionString;
            trackBar1.Maximum = Convert.ToInt16(Player.currentMedia.duration);
            trackBar1.Value = Convert.ToInt16(Player.Ctlcontrols.currentPosition);
            if (Player.Ctlcontrols.currentPositionString == Player.currentMedia.durationString)
            {
                if (listmusic.SelectedIndex != listmusic.Items.Count - 1)
                {
                    listmusic.SetSelected(listmusic.SelectedIndex + 1, true);
                    Player.URL = paths[listmusic.SelectedIndex];
                    text_judul.Text = listmusic.Text;
                }
            }
        }

        private void listmusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[listmusic.SelectedIndex];
            timer1.Start();
            text_judul.Text = listmusic.Text;
        }

        private void pb_play_Click(object sender, EventArgs e)
        {
            Player.URL = paths[listmusic.SelectedIndex];
            timer1.Start();
            text_judul.Text = listmusic.Text;
        }

        private void pb_pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            Player.Ctlcontrols.currentPosition = Convert.ToDouble(text_posisi.Text.Replace(":", ""));
        }

        private void pb_stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void pb_first_Click(object sender, EventArgs e)
        {
            listmusic.SetSelected(0, true);
            Player.URL = paths[listmusic.SelectedIndex];
            text_judul.Text = listmusic.Text;
        }

        private void pb_prev_Click(object sender, EventArgs e)
        {
            if (listmusic.SelectedIndex != 0)
            {
                listmusic.SetSelected(listmusic.SelectedIndex - 1, true);
                Player.URL = paths[listmusic.SelectedIndex];
                text_judul.Text = listmusic.Text;
            }
        }

        private void pb_next_Click(object sender, EventArgs e)
        {
            if (listmusic.SelectedIndex != listmusic.Items.Count - 1)
            {
                listmusic.SetSelected(listmusic.SelectedIndex + 1, true);
                Player.URL = paths[listmusic.SelectedIndex];
                text_judul.Text = listmusic.Text;
            }
        }

        private void pb_last_Click(object sender, EventArgs e)
        {
            listmusic.SetSelected(listmusic.Items.Count - 1, true);
            Player.URL = paths[listmusic.SelectedIndex];
            text_judul.Text = listmusic.Text;
        }

        private void tb_volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = tb_volume.Value;
            timer1.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = open_file.SafeFileNames;
                paths = open_file.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listmusic.Items.Add(files[i]);
                }
            }
        }
    }
}
