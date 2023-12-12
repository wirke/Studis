using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStudis
{
    internal class Student : Fakultet
    {
        protected string imePrezime {  get; set; }
        protected int JMBG { get; set; }
        protected int godina {  get; set; }
        protected string smer { get; set; } 
        protected double prosek { get; set; }
        protected int espb {  get; set; }
        protected Student()
        {
            imePrezime = string.Empty;
            JMBG = 0;
            godina = 0;
            smer = string.Empty;
            espb = 0;
            prosek = 0.00;
        }
        public Student(string imePrezime, int jMBG, int godina, string smer, double prosek, int espb)
        {
            this.imePrezime = imePrezime;
            JMBG = jMBG;
            this.godina = godina;
            this.smer = smer;
            this.prosek = prosek;
            this.espb = espb;
        }
    }
}
