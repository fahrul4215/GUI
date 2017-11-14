using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjangArray, a = 1;

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
                    Console.Write("Isi bilangan {0} = {1} \n", a, bilangan[i]);
                }                    
                a++;
            }

            Console.ReadKey();
        }
    }
}
