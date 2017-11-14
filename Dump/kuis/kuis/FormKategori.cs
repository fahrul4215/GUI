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
    public partial class FormKategori : Form
    {
        private List<Kategori> daftarKategori;

        public List<Kategori> DaftarKategori
        {
            get { return daftarKategori; }
            set { daftarKategori = value; }
        }
        

        public FormKategori(List<Kategori> daftarKategori)
        {
            InitializeComponent();
            this.DaftarKategori = daftarKategori;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Keterangan";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadKategori()
        {
            foreach (var kat in DaftarKategori)
            {
                dataGridView1.Rows.Add(kat.Keterangan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori item = new Kategori();
            item.Keterangan = textBox1.Text;
            DaftarKategori.Add(item);
            dataGridView1.Rows.Add(textBox1.Text);
        }

    }
}
