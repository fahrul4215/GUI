using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bilangan = new int[4];

            //bilangan[0] = 7;
            //bilangan[1] = 5;
            //bilangan[2] = 8;
            //bilangan[3] = 4;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Masukkan bilangan {0} : ", (i+1));
                bilangan[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            // {0} conversion speciifier

            //Console.Write("{0} ", bilangan[0]);
            //Console.Write("{0} ", bilangan[1]);
            //Console.Write("{0} ", bilangan[2]);
            //Console.Write("{0} \n", bilangan[3]);

            for (int i = 0; i < 4; i++) {
                Console.Write("Isi bilangan {0} = {1} \n", i+1, bilangan[i]);
            }

            Console.ReadKey();
        }
    }
}
