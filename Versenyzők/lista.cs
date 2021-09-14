using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Versenyzők
{
    class lista
    {
        private int nev;

        public int Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        private int szuletesi_datum;

        public int Szuletesi_datum
        {
            get { return szuletesi_datum; }
            set { szuletesi_datum = value; }
        }
        private int nemzetiseg;

        public int Nemzetiseg
        {
            get { return nemzetiseg; }
            set { nemzetiseg = value; }
        }
        private int rajtszam;

        public int Rajtszam
        {
            get { return rajtszam; }
            set { rajtszam = value; }
        }

        public lista(int nev, int szuletesi_datum, int nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }
    }
}
