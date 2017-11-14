using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjangArray, jumlah = 0;

            Console.Write("Masukkan panjang array : ");
            panjangArray = int.Parse(Console.ReadLine());

            int[] bilangan = new int[panjangArray];

            Console.WriteLine();
            for (int i = 0; i < panjangArray; i++)
            {
                Console.Write("Masukkan bilangan {0} : ", (i + 1));
                bilangan[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < panjangArray; i++)
            {
                if (bilangan[i] % 2 != 0)
                {
                    jumlah+=1;
                }
            }

            Console.Write("Jumlah nilai ganjil = {0} \n", jumlah);

            Console.ReadKey();
        }
    }
}
