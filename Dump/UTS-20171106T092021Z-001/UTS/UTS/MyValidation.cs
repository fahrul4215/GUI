using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    class MyValidation
    {
        public void txtIsEmptyValidation(TextBox txtToValidate, String txtName)
        {
            if (txtToValidate.Text == string.Empty)
            {
                if (MessageBox.Show("Kolom " + txtName + " Tidak Boleh Kosong", "Peringatan Kolom Kosong",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    txtToValidate.Focus();
                }
            }
        }

        public void txtIsMatchValidation(TextBox txtToValidate1, TextBox txtToValidate2, String txtName1, String txtName2)
        {
            if (txtToValidate2.Text != txtToValidate1.Text)
            {
                if (MessageBox.Show("Isi Kolom " + txtName2 + "Tidak Sama dengan Kolom" + txtName1 + " .Silahkan Periksa Kembali.",
                    "Peringatan Perbedaan Isis Kolom", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    txtToValidate2.Focus();
                }
            }
        }

        public void txtIsTextAndSpaceValidation(TextBox txtToValidate, String txtName)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtToValidate.Text, @"^[a-zA-Z\s]+$"))
            {
                if (MessageBox.Show("Kolom" + txtName + "Hanya boleh diisi dengan Huruf dan Spasi", "Peringatan Kesalahan Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    if (txtToValidate.Text.Length >= 1)
                    {
                        txtToValidate.Text = txtToValidate.Text.Remove(txtToValidate.Text.Length - 1);
                        txtToValidate.Focus();
                    }
                }
            }
        }

        public void txtIsNumberValidation(TextBox txtToValidate, String txtName)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtToValidate.Text, @"^[0-9]+$"))
            {
                if (MessageBox.Show("Kolom" + txtName + "Hanya boleh diisi dengan Angka", "Peringatan Kesalahan Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    if (txtToValidate.Text.Length >= 1)
                    {
                        txtToValidate.Text = txtToValidate.Text.Remove(txtToValidate.Text.Length - 1);
                        txtToValidate.Focus();
                    }
                }
            }
        }

        public void txtIsEmailValidation(TextBox txtToValidate, String txtName)
        {
            if (txtToValidate.Text == string.Empty)
            {
                if (MessageBox.Show("Kolom " + txtName + " Tidak Boleh Kosong", "Peringatan Kolom Kosong",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    txtToValidate.Focus();
                }
            }
            else
            {
                try
                {
                    var email_addr = new System.Net.Mail.MailAddress(txtToValidate.Text);
                }
                catch
                {
                    if (MessageBox.Show("Email yang anda masukkan pada kolom " + txtName + " Tidak Valid",
                        "Peringatan Email tidak VALID", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    {
                        txtToValidate.Focus();
                    }
                }
            }
        }

        public void txtIsNotFullFilledValidation(MaskedTextBox txtToValidate, String txtName)
        {
            if (!txtToValidate.MaskFull)
            {
                if (MessageBox.Show("Kolom " + txtName + "Harus diisi Penuh", "Peringatan Kolom Tidak Terisi Penuh",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    txtToValidate.Focus();
                }
            }
        }

        public void rbIsSelectedValidation(List<RadioButton> listRbToValidate, String rbName)
        {
            var isSelected = false;
            foreach (var item in listRbToValidate)
            {
                if (item.Checked)
                {
                    isSelected = true;
                    break;
                }
            }
            if (!isSelected)
            {
                if (MessageBox.Show("Kolom " + rbName + " Harus Dipilih Terlebih dahulu", "Peringatan Kolom Tidak Dipilih",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    listRbToValidate[0].Focus();
                }
            }
        }

    }
}
