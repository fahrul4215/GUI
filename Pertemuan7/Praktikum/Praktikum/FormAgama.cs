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
    public partial class FormAgama : Form
    {
        private List<Agama> _daftarAgama;

        public List<Agama> DaftarAgama
        {
            get { return _daftarAgama; }
            set { _daftarAgama = value; }
        }

        public FormAgama(List<Agama> daftarAgama)
        {
            InitializeComponent();
            this.DaftarAgama = daftarAgama;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Keterangan";
            loadAgama();
        }

        private void FormAgama_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agama itemAgama = new Agama();
            itemAgama.Keterangan = textBox1.Text;
            DaftarAgama.Add(itemAgama);
            dataGridView1.Rows.Add(textBox1.Text);
        }

        public void loadAgama()
        {
            foreach (var agama in DaftarAgama)
            {
                dataGridView1.Rows.Add(agama.Keterangan);
            }
        }
    }
}
