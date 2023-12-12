using System.Security.Policy;

namespace Studis.Server.Model
{
    public class Kredencijali
    {
        public int Id { get; set; }
        public string email { get; set; }
        public virtual Student Student { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
