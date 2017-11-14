using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuis
{
    public class Mahasiswa
    {
        private string nama;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        private string nim;
        
        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }

        public Mahasiswa(string nama, string nim)
        {
            // TODO: Complete member initialization
            this.Nama = nama;
            this.Nim = nim;
        }
    }
}
