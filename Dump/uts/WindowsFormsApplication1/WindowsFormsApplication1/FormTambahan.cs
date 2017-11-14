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
    public partial class FormTambahan : Form
    {
        private List<SewaTambahan> _tambahan;

        public FormTambahan()
        {
        }

        public FormTambahan(List<SewaTambahan> tambahan)
        {
            InitializeComponent();
            Tambahan = tambahan;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Nama";

            foreach (var tmbh in Tambahan)
            {
                dataGridView1.Rows.Add(tmbh.Nama);
            }

        }

        public List<SewaTambahan> Tambahan
        {
            get
            {
                return _tambahan;
            }

            set
            {
                _tambahan = value;
            }
        }

        private void FormTambahan_Load(object sender, EventArgs e)
        {

        }

        private void simpanButton_Click(object sender, EventArgs e)
        {
            SewaTambahan tambah = new SewaTambahan();
            tambah.Nama = namaText.Text;
            Tambahan.Add(tambah);
            dataGridView1.Rows.Add(tambah.Nama);
            namaText.Clear();
            namaText.Focus();
        }
    }
}
