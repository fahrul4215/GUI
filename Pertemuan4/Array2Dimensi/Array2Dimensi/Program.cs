using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] bilangan = new int[6,5];
            int baris, kolom;

            for (baris = 0; baris <= 5; baris++) {
                for (kolom = 0; kolom < 5; kolom++) {
                    bilangan[baris,kolom] = (baris + 2) * (kolom + 2);
                }
            }
            for (baris = 0; baris <= 5; baris++) {
                for (kolom = 0; kolom < 5; kolom++) {
                    Console.Write("{0} \t", bilangan[baris,kolom]);
                }
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();
        }
    }
}
