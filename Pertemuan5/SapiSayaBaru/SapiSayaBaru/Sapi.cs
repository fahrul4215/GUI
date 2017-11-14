using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapiSayaBaru
{
    class Sapi
    {
        //public string nama;
        //public string jenisKelamin;
        //public int umur;
        //public int berat;

        // Private untuk Setter/Getter
        private string nama;
        private string jenisKelamin = "Jantan";
        private int jumlahKaki = 4;
        private int umur = 11;

        // Setter
        public void GantiNama(string namaBaru)
        {
            nama = namaBaru;
        }
        // Getter
        public string LihatNama()
        {
            return nama;
        }
        // Getter
        public string LihatJenisKelmain()
        {
            return jenisKelamin;
        }

        public int LihatJumlahKaki()
        {
            return jumlahKaki;
        }

        public int LihatUmur()
        {
            return umur;
        }
    }
}
