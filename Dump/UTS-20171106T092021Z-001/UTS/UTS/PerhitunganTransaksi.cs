using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class PerhitunganTransaksi
    {
        public int harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public virtual int Harga()
        {
            return harga;
        }
    }
}
