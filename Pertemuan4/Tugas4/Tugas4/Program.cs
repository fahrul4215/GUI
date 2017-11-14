using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas4
{
    class Program
    {
        static void Main(string[] args)
        {
            string jabatan = "presiden", input;

            Console.Write("Masukan jenis jabatan pemerintahan : ");
            input = Console.ReadLine();

            //if (input.Equals(jabatan))
            //    Console.WriteLine("Jokowi adalah " + jabatan);
            //else
            //    Console.WriteLine("Jokowi bukan " + input);

            if (input == "presiden" || input == "Presiden" || input == "PRESIDEN")
                Console.WriteLine("\nJokowi adalah " + jabatan);
            else
                Console.WriteLine("\nJokowi bukan " + input);

            Console.ReadLine();
        }
    }
}
