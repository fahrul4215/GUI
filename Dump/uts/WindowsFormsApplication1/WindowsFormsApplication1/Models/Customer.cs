using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Customer
    {
        string nama;
        string alamat;
        int jumlahJam;

        public string Nama
        {
            get
            {
                return nama;
            }

            set
            {
                nama = value;
            }
        }

        public string Alamat
        {
            get
            {
                return alamat;
            }

            set
            {
                alamat = value;
            }
        }

        public int JumlahJam
        {
            get
            {
                return jumlahJam;
            }

            set
            {
                jumlahJam = value;
            }
        }
    }
}
