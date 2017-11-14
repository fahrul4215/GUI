using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        private List<SewaTambahan> sewa = new List<SewaTambahan>();
        private List<Transaksi> trans = new List<Transaksi>();

        public List<SewaTambahan> Sewa
        {
            get
            {
                return sewa;
            }

            set
            {
                sewa = value;
            }
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void dataSewaTambahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTambahan frmTambah = new FormTambahan(Sewa);
            frmTambah.ShowDialog();
            this.Sewa = frmTambah.Tambahan;
        }

        private void transaksiPersewaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi frmTransaksi = new FormTransaksi(Sewa, trans);
            frmTransaksi.ShowDialog();
            this.trans = frmTransaksi.Transaksi;
        }
    }
}
