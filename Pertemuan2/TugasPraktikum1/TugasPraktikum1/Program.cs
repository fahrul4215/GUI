using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inGol, inNama;
            int gaji, pajak, tunjangan;

            Console.WriteLine("\t\tHitung Gaji Pegawai");
            Console.Write("\nMasukkan nama anda : ");
            inNama = Console.ReadLine();
            Console.Write("\nMasukkan Golongan anda : ");
            inGol = Console.ReadLine();

            if (inGol == "A" || inGol == "a")
            {
                gaji = 1000000;
                tunjangan = 50000;
                pajak = (int) (0.10 * gaji);
                hitung(inNama, gaji, tunjangan, pajak);
            }
            else if (inGol == "B" || inGol == "b")
            {
                gaji = 2000000;
                tunjangan = 150000;
                pajak = (int)(0.25 * gaji);
                hitung(inNama, gaji, tunjangan, pajak);
            }
            else {
                Console.WriteLine("Pilihan salah");
            }

        }

        static public void hitung(string namanya, int gajinya, int tunjangannya, int pajaknya) {
            int gajiTotal;
            gajiTotal = gajinya + tunjangannya - pajaknya;

            Console.WriteLine("===========================");
            Console.WriteLine("Nama : " + namanya);
            Console.WriteLine("Gaji : " + gajinya);
            Console.WriteLine("Tunjangan : " + tunjangannya);
            Console.WriteLine("Pajak : " + pajaknya);
            Console.WriteLine("===========================");
            Console.WriteLine("Gaji Total : " + gajiTotal);
        }
    }
}
