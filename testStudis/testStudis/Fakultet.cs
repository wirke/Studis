using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStudis
{
    internal class Fakultet
    {
        protected string Naziv {  get; set; }
        protected Fakultet()
        {
            Naziv = string.Empty;
        }
        public Fakultet (string Naziv)
        {
            this.Naziv = Naziv;
        }
    }
}
