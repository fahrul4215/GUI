using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            Console.Write("Masukkan bilangan : ");
            s = int.Parse(Console.ReadLine());
            /*if (s % 2 == 0)
            {
                Console.Write("Bilangan yang dimasukkan adalah genap");
            }
            else {
                Console.Write("Bilangan yang dimasukkan adalah ganjil");
            }*/

            if (s == 0)
            {
                Console.Write("Bilangan yang dimasukkan adalah nol");
            }
            else if(s>0)
            {
                Console.Write("Bilangan yang dimasukkan adalah positif");
            }
            else
            {
                Console.Write("Bilangan yang dimasukkan adalah negatif");
            }

            Console.ReadKey();
        }
    }
}
