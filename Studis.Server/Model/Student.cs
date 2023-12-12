namespace Studis.Server.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public int JMBG { get; set; }
        public string Smer { get; set; }
        public string Semestar { get; set; }
        public int Prosek { get; set; }
        public int ESPB { get; set; }
        public int Bilans { get; set; }
        public Boolean Status { get; set; }

        public IEnumerable<Predmet> Predmeti { get; set; }
    }
}