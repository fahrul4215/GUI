using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Transaksi
    {
        SewaTambahan barangTambahan;
        Customer cust;
        int hargaTotal;
        int kembalian;
        int bayar;
        int noTrans;


        internal SewaTambahan BarangTambahan
        {
            get
            {
                return barangTambahan;
            }

            set
            {
                barangTambahan = value;
            }
        }

        

        public int NoTrans
        {
            get
            {
                return noTrans;
            }

            set
            {
                noTrans = value;
            }
        }

        public Customer Cust
        {
            get
            {
                return cust;
            }

            set
            {
                cust = value;
            }
        }

        public int HargaTotal
        {
            get
            {
                return hargaTotal;
            }

            set
            {
                hargaTotal = value;
            }
        }

        public int Kembalian
        {
            get
            {
                return kembalian;
            }

            set
            {
                kembalian = value;
            }
        }

        public int Bayar
        {
            get
            {
                return bayar;
            }

            set
            {
                bayar = value;
            }
        }

        public int hitungTotal(int jumlahJam, int index)
        {
            HargaTotal = 35000 * jumlahJam;
            if (index<0)
            {
                HargaTotal += (5000 * jumlahJam);
            }
            if (jumlahJam > 3)
            {
                HargaTotal = ((20 / 100) * 35000);
            }
            return HargaTotal;
        }

        public int hitungKembalian(int bayar)
        {
            Kembalian = bayar - HargaTotal;
            return Kembalian;
        }
    }
}
