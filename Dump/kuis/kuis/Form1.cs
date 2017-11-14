using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuis
{
    public partial class Form1 : Form
    {
        Mahasiswa m = new Mahasiswa("eka", "1631710127");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (m.Nama == textBox1.Text && m.Nim == textBox2.Text)
            {
                Forms home = new Forms();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau Password yang anda masukkan salah!!!", "LOGIN GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
