using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Transaksi : Form
    {
        Harga5 h5 = new Harga5();
        Harga10 h10 = new Harga10();
        Harga20 h20 = new Harga20();
        public int harga;
        private Pendaftaran pendaftaran = new Pendaftaran();

        public Pendaftaran Pendaftaran { get => pendaftaran; set => pendaftaran = value; }

        public Transaksi(Pendaftaran pendaftaran)
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Provider";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Nominal";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Name = "Harga";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Name = "Nomer";
            dataGridView1.Columns[3].Width = 120;
            this.Pendaftaran = pendaftaran;
            load_transaksi();
        }

        private void nominalcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nominalcomboBox.Text == "5000") 
            {
                harga = h5.Harga();
            }
            else if (nominalcomboBox.Text == "10000")
            {
                harga = h10.Harga();
            }
            else if (nominalcomboBox.Text == "20000")
            {
                harga = h20.Harga();
            }
        }

        private void HapusTbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }

            providercomboBox.Text = "PILIH PROVIDER";
            nominalcomboBox.Text = "PILIH NOMINAL";
            hargatextBox.Text = "";
            nomerTmaskedTextBox.Text = "";
        }

        private void SimpanTbutton_Click(object sender, EventArgs e)
        {
            if (hargatextBox.Text != "" && nomerTmaskedTextBox.Text != "")
            {
                string[] row = new string[] { providercomboBox.Text, nominalcomboBox.Text, hargatextBox.Text, nomerTmaskedTextBox.Text };
                dataGridView1.Rows.Add(row);
            }
        }

        private void tambahsaldobutton_Click(object sender, EventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        public void load_transaksi()
        {
            nomerTmaskedTextBox.Text = Pendaftaran.Nohp;
            saldotextBox.Text = Pendaftaran.Saldo.ToString();
        }
    }
}
