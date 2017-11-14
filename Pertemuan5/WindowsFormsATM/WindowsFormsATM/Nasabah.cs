using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsATM
{
    class Nasabah
    {
        private String firstname;
        private String lastname;
        private Rekening rekening;

        public Nasabah(string f, string l, Rekening r) //Constructor
        {
            this.mFirstname = f;
            this.mLastname = l;
            this.mRekening = r;
        }

        public Rekening mRekening
        {
            get { return rekening; }
            set { rekening = value; }
        }

        public String mLastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public String mFirstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
    }
}
