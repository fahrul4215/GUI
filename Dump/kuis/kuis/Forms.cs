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
    public partial class Forms : Form
    {
        public List<Kategori> daftarKategori = new List<Kategori>();


        public Forms()
        {
            InitializeComponent();
        }

        private void daftarBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarBuku dftrBuku = new DaftarBuku();
            dftrBuku.ShowDialog();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori formKategori = new FormKategori(daftarKategori);
            formKategori.ShowDialog();
            this.daftarKategori = formKategori.DaftarKategori;
        }
    }
}
