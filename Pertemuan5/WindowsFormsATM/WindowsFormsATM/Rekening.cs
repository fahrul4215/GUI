using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsATM
{
    class Rekening
    {
        private double saldo;

        public Rekening(double s)
        {
            this.mSaldo = s;
        }

        public double mSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Tarik(double jumlah)
        {
            mSaldo -= jumlah;
        }

        public void Setor(double jumlah)
        {
            mSaldo += jumlah;
        }
    }
}
