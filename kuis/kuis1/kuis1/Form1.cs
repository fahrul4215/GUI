using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuis1
{
    public partial class Form1 : Form
    {
        
        KonversiSuhu konversi = new KonversiSuhu();
        Akun fahrul = new Akun("M. Fahrul Yurisnan", "1631710057", "MI-2A", "D3 Manajemen Informatika");
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Inputan ERROR";
            }
            else
            {
                textBox2.Text = "" + konversi.keFahrenheit(int.Parse(textBox1.Text)) + " Fahrenheit";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Inputan ERROR";
            }
            else
            {
                textBox2.Text = "" + konversi.keKelvin(int.Parse(textBox1.Text)) + " Kelvin";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info.Text = fahrul.tampilInfo();
        }
    }
}
