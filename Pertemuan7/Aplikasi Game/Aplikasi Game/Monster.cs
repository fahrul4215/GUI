using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Game
{
    class Monster
    {
        private int nyawa;

        public int Nyawa
        {
            get { return nyawa; }
            set { nyawa = value; }
        }

        public void Menyerang()
        {
            Console.WriteLine("Monster Menyerang dengan sangat brutal");
        }

        public void MelarikanDiri()
        {
            Console.WriteLine("Monster Melarikan Diri");
        }

    }
}
