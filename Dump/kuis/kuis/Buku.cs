using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuis
{
    class Buku
    {
        private string judul;

        public string Judul
        {
            get { return judul; }
            set { judul = value; }
        }

        private string namaPenulis;

        public string NamaPenulis
        {
            get { return namaPenulis; }
            set { namaPenulis = value; }
        }

        private string penerbit;

        public string Penerbit
        {
            get { return penerbit; }
            set { penerbit = value; }
        }

        private string tahunTerbit;

        public string TahunTerbit
        {
            get { return tahunTerbit; }
            set { tahunTerbit = value; }
        }

        private string kategori;

        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
        
    }
}
