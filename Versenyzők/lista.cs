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
        private string nev;

        public string Nev
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
        private string nemzetiseg;

        public string Nemzetiseg
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

        public lista(string nev, int szuletesi_datum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesi_datum = szuletesi_datum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }
    }
}
