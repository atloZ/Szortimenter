using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szortimenter
{
    class Fajl
    {
        private string nev;
        private string kiterjesztes;

        public string Nev { get => nev; set => nev = value; }
        public string Kiterjesztes { get => kiterjesztes; set => kiterjesztes = value; }
        public string TeljNev { get => this.nev + "." + this.kiterjesztes; }
        
        public Fajl(string file)
        {
            string[] elemek = file.Split('.');
            if (elemek.Length == 2)
            {
                this.nev = elemek[0];
                this.kiterjesztes = elemek[1];
            }
        }
    }
}
