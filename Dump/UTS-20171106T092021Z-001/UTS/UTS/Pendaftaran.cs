using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public class Pendaftaran
    {
        private String username;
        private String password;
        private String nama;
        private String email;
        private string nohp;
        private String alamat;
        private int saldo;
        private String jk;
        //private string text1;
        //private string text2;
        //private string text3;
        //private string text4;
        //private int v;

        public Pendaftaran()
        {

        }

        public Pendaftaran(int saldo)
        {
            this.saldo = saldo;
        }

        public Pendaftaran (String username,String password)
        {
            this.username = username;
            this.password = password;
        }

        public Pendaftaran(String username,String password,String nama,String email,String nohp,String alamat,int saldo)
        {
            this.username = username;
            this.password = password;
            this.nama = nama;
            this.email = email;
            this.nohp = nohp;
            this.alamat = alamat;
            this.saldo = saldo;
        
        }

        //public Pendaftaran(string username, string password, string text1, string text2, string text3, string text4, int v) : this(username, password)
        //{
        //    this.text1 = text1;
        //    this.text2 = text2;
        //    this.text3 = text3;
        //    this.text4 = text4;
        //    this.v = v;
        //}

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
    
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Nohp
        {
            get { return nohp; }
            set { nohp = value; }
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public String Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string Jk { get => jk; set => jk = value; }
    }
}
