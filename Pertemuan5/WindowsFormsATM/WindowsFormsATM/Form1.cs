using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsATM
{
    public partial class Form1 : Form
    {
        private Nasabah currentNasabah;
        public Form1()
        {
            InitializeComponent();
            simulasiLogin();
        }

        public void simulasiLogin()
        {
            Rekening r = new Rekening(19000000); // informasi akun
            Nasabah ronaldo = new Nasabah("Cristiano", "Ronaldo", r);
            currentNasabah = ronaldo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("Saldo anda adalah : " + currentNasabah.mRekening.mSaldo);
            textBox2.AppendText(Environment.NewLine); // baris baru
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.AppendText("Inputan Kosong");
                textBox2.AppendText(Environment.NewLine);
            }
            else
            {
                currentNasabah.mRekening.Setor(double.Parse(textBox1.Text));
                textBox2.AppendText("Anda Menyetor : " + textBox1.Text);
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("Saldo Anda adalah : " + currentNasabah.mRekening.mSaldo);
                textBox2.AppendText(Environment.NewLine);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.AppendText("Inputan Kosong");
                textBox2.AppendText(Environment.NewLine);
            }
            else
            {
                currentNasabah.mRekening.Tarik(double.Parse(textBox1.Text));
                textBox2.AppendText("Anda Menarik : " + textBox1.Text);
                textBox2.AppendText(Environment.NewLine);
                textBox2.AppendText("Saldo Anda adalah : " + currentNasabah.mRekening.mSaldo);
                textBox2.AppendText(Environment.NewLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        
    }
}
