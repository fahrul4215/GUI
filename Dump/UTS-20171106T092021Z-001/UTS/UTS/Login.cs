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
    public partial class Login : Form
    {
        MyValidation myValidation = new MyValidation();

        public Pendaftaran dftr = new Pendaftaran();

        public Login()
        {
            InitializeComponent();

        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {
            myValidation.txtIsEmptyValidation(usernametextBox, "User Login");
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
            myValidation.txtIsEmptyValidation(passwordtextBox, "Password Login");
        }

        private void daftaruserbutton_Click(object sender, EventArgs e)
        {
            Daftar frmdaftar = new Daftar();
            frmdaftar.ShowDialog();
            this.dftr = frmdaftar.Dftr;
        }

        private void loginuserbutton_Click(object sender, EventArgs e)
        {
            if (dftr.Username == usernametextBox.Text && dftr.Password == passwordtextBox.Text)
            {
                Transaksi trans = new Transaksi(dftr);
                trans.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username atau Password yang anda masukkan salah", "LOGIN GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
