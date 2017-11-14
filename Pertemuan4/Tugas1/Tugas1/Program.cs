using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1
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
            for (int i = panjangArray; i > 0; i--)
            {
                Console.Write("Isi bilangan {0} = {1} \n", a, bilangan[i-1]);
                a++;
            }

            Console.ReadKey();
        }
    }
}
