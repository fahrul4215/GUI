using Praktikum.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum
{
    public partial class Form1 : Form
    {
        public List<Agama> daftarAgama = new List<Agama>();
        public List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda Yakin Menutup Aplikasi ?", "Tutup Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void agamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgama frmagama = new FormAgama(daftarAgama);
            frmagama.ShowDialog();
            this.daftarAgama = frmagama.DaftarAgama;
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMahasiswa frmMahasiswa = new FormMahasiswa(daftarAgama, daftarMahasiswa);
            frmMahasiswa.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
