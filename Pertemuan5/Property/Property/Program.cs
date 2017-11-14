using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            segiempat s = new segiempat();

            s.Panjang = -2;
            s.Lebar = 7;

            Console.WriteLine("Luas : {0}\nKeliling : {1}", s.HitungLuasSegiempat(), s.HitungKelilingSegiempat);

            Console.ReadKey();
        }
    }
}
