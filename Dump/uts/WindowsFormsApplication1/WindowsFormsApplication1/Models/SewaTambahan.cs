using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class SewaTambahan
    {
        String nama;
        int harga;

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

        public int Harga
        {
            get
            {
                return harga;
            }

            set
            {
                harga = value;
            }
        }
    }
}
