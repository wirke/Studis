using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStudis
{
    internal class Profesor : Fakultet
    {
        protected string imePrezime { get; set; }
        protected Profesor()
        {
            imePrezime = string.Empty;
        }
        public Profesor(string imePrezime, int jMBG, int godina, string smer, double prosek, int espb)
        {
            this.imePrezime = imePrezime;
        }
    }
}
