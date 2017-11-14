using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Property Lenght
            //string str;
            //int panjang;

            //string[] array = new string[5];

            //str = "halo";
            //panjang = array.Length;
            //Console.Write("{0}", panjang);

            //String Operator Concat
            string str1, str2;

            str1 = "ha";
            str2 = str1 + "lo";
            Console.WriteLine("{0}\n{1}\n", str1, str2);

            //String Operator Sama Dengan
            //string str1, str2;

            //str1 = "halo";
            //str2 = str1;
            //if (str2 == "halo")
            //    Console.Write("sama \n\n");
            //else
            //    Console.Write("tidak sama \n\n");

            Console.ReadKey();
        }
    }
}
