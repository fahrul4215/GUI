using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuis1
{
    class KonversiSuhu
    {
        public int keFahrenheit(int celcius)
        {
            return (9*celcius / 5) + 32;
        }

        public int keKelvin(int celcius)
        {
            return celcius + 273;
        }
    }
}
