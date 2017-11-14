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
    public partial class Daftar : Form
    {
        MyValidation myValidation = new MyValidation();
        List<RadioButton> listRbJenisKelamin = new List<RadioButton>();
        private Pendaftaran dftr = new Pendaftaran();

        public Pendaftaran Dftr { get => dftr; set => dftr = value; }

        public Daftar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void userdaftartextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void daftarbutton_Click(object sender, EventArgs e)
        {
            myValidation.txtIsEmptyValidation(userdaftartextBox, "User Daftar");
            myValidation.txtIsTextAndSpaceValidation(userdaftartextBox, " User Daftar");

            myValidation.txtIsEmptyValidation(passworddaftartextBox, "Password");
            myValidation.txtIsMatchValidation(passworddaftartextBox, kpasswordtextBox, "Password", "Konfirmasi Password");

            myValidation.txtIsTextAndSpaceValidation(namalengkaptextBox, "Nama Lengkap");

            myValidation.txtIsEmptyValidation(emailtextBox, "Email");
            myValidation.txtIsNotFullFilledValidation(nohpmaskedTextBox, "No HandPhone");

            listRbJenisKelamin.Add(lakiradioButton);
            listRbJenisKelamin.Add(perempuanradioButton);
            myValidation.rbIsSelectedValidation(listRbJenisKelamin, "Jenis Kelamin");

            Dftr.Username = userdaftartextBox.Text;
            Dftr.Password = passworddaftartextBox.Text;
            Dftr.Nama = namalengkaptextBox.Text;
            Dftr.Email = emailtextBox.Text;
            Dftr.Nohp = nohpmaskedTextBox.Text;
            Dftr.Alamat = alamattextBox.Text;
            Dftr.Saldo = int.Parse(saldoDtextBox.Text);

            if (lakiradioButton.Checked)
            {
                Dftr.Jk = lakiradioButton.Text;
            } else if (perempuanradioButton.Checked)
            {
                Dftr.Jk = perempuanradioButton.Text;
            }

            MessageBox.Show("Pendaftaran Berhasil", "Daftar Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            //MessageBox.Show("Username : " + dftr.Username + "\n" +
            //                "Password : " + dftr.Password + "\n" +
            //                "Nama Lengkap : " + dftr.Nama + "\n" +
            //                "Email : " + dftr.Email + "\n" +
            //                "No hp : " + dftr.Nohp + "\n" +
            //                "Alamat : " + dftr.Alamat + "\n" +
            //                "saldo " + dftr.Saldo + "\n" +
            //                "Jenis Kelamin : " + dftr.Jk);
         
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            userdaftartextBox.Text = "";
            passworddaftartextBox.Text = "";
            kpasswordtextBox.Text = "";
            namalengkaptextBox.Text = "";
            emailtextBox.Text = "";
            nohpmaskedTextBox.Text = "";
            alamattextBox.Text = "";
            lakiradioButton.Checked = false;
            perempuanradioButton.Checked = false;

        }
    }
}
