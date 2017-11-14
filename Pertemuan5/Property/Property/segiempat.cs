using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class segiempat
    {
        private double _panjang;
        private double _lebar;

        public double Panjang
        {
            get { return _panjang; }
            set
            {
                if (value > 0)
                    _panjang = value;
                else
                    _panjang = 1;
            }
        }
        
        public double Lebar
        {
            get { return _lebar; }
            set
            {
                if (value > 0)
                    _lebar = value;
                else
                    _lebar = 1;
            }
        }

        public double HitungLuasSegiempat()
        {
            return Panjang * Lebar;
        }

        public double HitungKelilingSegiempat
        {
            get { return 2 * (Panjang + Lebar); }
        }
    }
}
