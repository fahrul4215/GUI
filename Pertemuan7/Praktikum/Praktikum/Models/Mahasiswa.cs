using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Models
{
    public class Mahasiswa
    {
        private string _nama;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        private string _nim;

        public string Nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        private Agama _agama;

        public Agama Agama
        {
            get { return _agama; }
            set { _agama = value; }
        }

        private string _ttl;

        public string Ttl
        {
            get { return _ttl; }
            set { _ttl = value; }
        }

        private string _jurusan;

        public string Jurusan
        {
            get { return _jurusan; }
            set { _jurusan = value; }
        }

        private string _alamat;

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }
    }
}
