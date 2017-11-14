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
    public partial class FormMahasiswa : Form
    {
        private List<Agama> _daftarAgama;

        public List<Agama> DaftarAgama
        {
            get { return _daftarAgama; }
            set { _daftarAgama = value; }
        }

        private List<Mahasiswa> _daftarMahasiswa;

        public List<Mahasiswa> DaftarMahasiswa
        {
            get { return _daftarMahasiswa; }
            set { _daftarMahasiswa = value; }
        }

        public FormMahasiswa()
        {
            InitializeComponent();
        }

        public FormMahasiswa(List<Models.Agama> daftarAgama, List<Models.Mahasiswa> daftarMahasiswa)
        {
            InitializeComponent();
            _daftarAgama = daftarAgama;
            _daftarMahasiswa = daftarMahasiswa;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Nama";
            dataGridView1.Columns[1].Name = "Nim";
            dataGridView1.Columns[2].Name = "Agama";
            dataGridView1.Columns[3].Name = "TTL";
            dataGridView1.Columns[4].Name = "Jurusan";
            dataGridView1.Columns[5].Name = "Alamat";

            loadMahasiswa();

            for (int i = 0; i < daftarAgama.Count(); i++)
            {
                comboBox1.Items.Add(new Item(i, daftarAgama.ElementAt(i).Keterangan));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Data yang anda masukkan tidak boleh kosong", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa itemMahasiswa = new Mahasiswa();
                itemMahasiswa.Nama = textBox1.Text;
                itemMahasiswa.Nim = textBox2.Text;
                itemMahasiswa.Agama = DaftarAgama.ElementAt(comboBox1.SelectedIndex);
                itemMahasiswa.Ttl = dateTimePicker1.Text;
                itemMahasiswa.Jurusan = comboBox2.SelectedText;
                itemMahasiswa.Alamat = textBox3.Text;
                DaftarMahasiswa.Add(itemMahasiswa);
                dataGridView1.Rows.Add(itemMahasiswa.Nama, itemMahasiswa.Nim, itemMahasiswa.Agama.Keterangan, itemMahasiswa.Ttl, itemMahasiswa.Jurusan, itemMahasiswa.Alamat);
            }
        }

        public void loadMahasiswa()
        {
            foreach (var mahasiswa in DaftarMahasiswa)
            {
                dataGridView1.Rows.Add(mahasiswa.Nama, mahasiswa.Nim, mahasiswa.Agama.Keterangan, mahasiswa.Ttl, mahasiswa.Jurusan, mahasiswa.Alamat);
            }
        }
    }

    class Item
    {
        public string Name;
        public int Value;

        public Item(int value, string name)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
