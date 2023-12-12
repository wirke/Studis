using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStudis
{
    internal class Predmet : Fakultet
    {
        protected string naziv {  get; set; }
        protected int espb { get; set; }
        protected string smer { get; set; }
        protected string godina { get; set; }
        protected Predmet()
        {
            naziv = string.Empty;
            espb = 0;
            smer = string.Empty;
            godina = string.Empty;
        }
        public Predmet(string naziv, int espb, string smer, string godina)
        {
            this.naziv = naziv;
            this.espb = espb;
            this.smer = smer;
            this.godina = godina;
        }
    }
}
