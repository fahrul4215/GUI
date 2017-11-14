using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kalelawar lowo = new Kalelawar();
            //Kerbau kebo = new Kerbau();
            //Gurita gurita = new Gurita();
            //Kecoa coro = new Kecoa();

            //kebo.Berjalan();
            //lowo.Terbang();
            //gurita.Berenang();
            //coro.Menyerang();

            Monster[] monsters = new Monster[5];

            monsters[0] = new Kerbau();
            monsters[1] = new Kalelawar();
            monsters[2] = new Kecoa();
            monsters[3] = new Kerbau();
            monsters[4] = new Gurita();

            for (int i = 0; i < 5; i++)
            {
                if (monsters[i] is Kerbau)
                {
                    (monsters[i] as Kerbau).Berjalan();
                }
                else
                {
                    monsters[i].MelarikanDiri();
                }
            }

            Console.ReadKey();
        }
    }
}
