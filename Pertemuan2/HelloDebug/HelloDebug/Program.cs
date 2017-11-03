using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan pilihan bangun datar (Persegi/Segitiga) : ");
            String inJenis;
            inJenis = Console.ReadLine();
            if (inJenis == "Persegi") {
                hitungLuasPersegi();
            }
            else if (inJenis == "Segitiga") { 
            
            }
        }

        static void hitungLuasPersegi() {
            string inPanjang, inLebar;
            int panjang, lebar, luas;
            Console.Write("Masukkan Panjang Persegi : ");
            inPanjang = Console.ReadLine();
            Console.Write("Masukkan Lebar Persegi : ");
            inLebar = Console.ReadLine();

            panjang = int.Parse(inPanjang);
            lebar = int.Parse(inLebar);

            luas = panjang * lebar;

            Console.WriteLine("Luasnya adalah "+luas);
        }
    }
}
