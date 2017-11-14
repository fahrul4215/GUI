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
    public partial class FormTransaksi : Form
    {
        List<Transaksi> transaksi = new List<Transaksi>();
        private List<SewaTambahan> tambahan;
        string kembali;
        int no = 1;
        Transaksi t1 = new Transaksi();

        public List<Transaksi> Transaksi
        {
            get
            {
                return transaksi;
            }

            set
            {
                transaksi = value;
            }
        }

        public List<SewaTambahan> Tambahan
        {
            get
            {
                return tambahan;
            }

            set
            {
                tambahan = value;
            }
        }

        public FormTransaksi(List<SewaTambahan> sewa, List<Transaksi> trans)
        {
            InitializeComponent();
            Tambahan = sewa;
            Transaksi = trans;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "No. Transaksi";
            dataGridView1.Columns[1].Name = "Nama Pemesan";
            dataGridView1.Columns[2].Name = "Alamat";
            dataGridView1.Columns[3].Name = "Sewa Tambahan";
            dataGridView1.Columns[4].Name = "Jumlah jam";
            dataGridView1.Columns[5].Name = "Harga Total";
            dataGridView1.Columns[6].Name = "Bayar";
            dataGridView1.Columns[7].Name = "Kembalian";

            foreach (var transs in Transaksi)
            {
                dataGridView1.Rows.Add(transs.NoTrans, transs.Cust.Nama, transs.Cust.Alamat, transs.BarangTambahan.Nama,
                    transs.Cust.JumlahJam, transs.HargaTotal, transs.Bayar, transs.Kembalian);
            }

            foreach (var item in Tambahan)
            {
                tambahanCombo.Items.Add(item.Nama);
            }
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            namaText.Clear();
            alamatText.Clear();
            tambahanCombo.SelectedIndex = -1;
            jumlahText.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void jumlahText_TextChanged(object sender, EventArgs e)
        {
            t1.hitungTotal(int.Parse(jumlahText.Text), tambahanCombo.SelectedIndex);

            totalText.Text = t1.HargaTotal.ToString();
        }

        private void bayarText_TextChanged(object sender, EventArgs e)
        {
            kembali = t1.hitungKembalian(int.Parse(bayarText.Text)).ToString();
            if (int.Parse(bayarText.Text) < t1.HargaTotal)
            {
                kembaliText.Text = "uang tidak cukup";
            }
            else
            {
                kembaliText.Text = kembali;
            }
        }

        private void sewaButton_Click(object sender, EventArgs e)
        {
            t1.NoTrans = int.Parse(noText.Text);
            t1.Cust.Nama = namaText.Text;
            t1.Cust.Alamat = alamatText.Text;
            t1.BarangTambahan = tambahan.ElementAt(tambahanCombo.SelectedIndex);
            t1.Cust.JumlahJam = int.Parse(jumlahText.Text);
            t1.HargaTotal = int.Parse(totalText.Text);
            t1.Bayar = int.Parse(bayarText.Text);
            t1.Kembalian = int.Parse(kembali);
            Transaksi.Add(t1);
            dataGridView1.Rows.Add(t1.NoTrans, t1.Cust.Nama, t1.Cust.Alamat, t1.BarangTambahan.Nama,
                    t1.Cust.JumlahJam, t1.HargaTotal, t1.Bayar,t1.Kembalian);
        }

        private void tambahanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
