using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;

            c = 40;

            Console.Write("sebagai karakter, variabel c = {0} \n", c);
            Console.Write("sebagai bilangan, variabel c = {0} \n\n", (char)(c));

            Console.ReadKey();
        }
    }
}
