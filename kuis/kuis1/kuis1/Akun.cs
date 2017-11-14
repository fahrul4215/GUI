using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuis1
{
    class Akun
    {
        private string _nama;
        private string _nim;
        private string _kelas;
        private string _jurusan;

        public Akun(string nama, string nim, string kelas, string jurusan)
        {
            this._nama = nama;
            this._nim = nim;
            this._kelas = kelas;
            this._jurusan = jurusan;
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        public string Kelas
        {
            get { return _kelas; }
            set { _kelas = value; }
        }

        public string Jurusan
        {
            get { return _jurusan; }
            set { _jurusan = value; }
        }

        public string tampilInfo()
        {
            string info = "";
            info += "Nama\t : "+ _nama;
            info += "\nNim\t : "+ _nim;
            info += "\nKelas\t : "+ _kelas;
            info += "\nProdi\t : "+ _jurusan;

            return info;
        }

    }
}
