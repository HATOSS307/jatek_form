using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek_form
{
    internal class jatekok
    {
        int id;
        string nev;
        string jatekido;
        string studio;
        double osszertekertekeles;

      
        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Jatekido { get => jatekido; set => jatekido = value; }
        public string Studio { get => studio; set => studio = value; }
        public double Osszertekertekeles { get => osszertekertekeles; set => osszertekertekeles = value; }

        public jatekok(int id,string nev, string jatekido, string studio, double osszertekertekeles)
        {
            Id = id;
            Nev = nev;
            Jatekido = jatekido;
            Studio = studio;
            Osszertekertekeles = osszertekertekeles;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
