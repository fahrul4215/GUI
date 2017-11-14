using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Editor_Teks
{
    public partial class Form1 : Form
    {

        FontFamily[] ff = FontFamily.Families;
        

        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily item in ff)
            {
                cb_tipeFont.Items.Add(item.Name);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                output.Text = tb_inputText.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            output.ForeColor = colorDialog1.Color;
        }

        private void cb_tipeFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ukuranFont.SelectedIndex < 0)
            {
                output.Font = new Font(cb_tipeFont.SelectedItem.ToString(), 9);
            }
            else
            {
                output.Font = new Font(cb_tipeFont.SelectedItem.ToString(), 
                    float.Parse(cb_ukuranFont.SelectedItem.ToString()));
            }
        }

        private void cb_ukuranFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipeFont.SelectedIndex < 0)
            {
                output.Font = new Font("Arial", float.Parse(cb_ukuranFont.SelectedItem.ToString()));
            }
            else
            {
                output.Font = new Font(cb_tipeFont.SelectedItem.ToString(),
                    float.Parse(cb_ukuranFont.SelectedItem.ToString()));
            }
        }
    }
}
