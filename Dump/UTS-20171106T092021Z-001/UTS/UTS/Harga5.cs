﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Harga5 : PerhitunganTransaksi
    {
        public override int Harga()
        {
            return base.Harga()+5500;
        }
    }
}
