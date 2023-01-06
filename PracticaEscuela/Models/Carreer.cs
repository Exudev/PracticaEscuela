namespace PracticaEscuela.Models
{
    public class Carreer
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Subject> Subjects { get; set; }
        public int MaxCredits { get; set; }
        public Carreer(string name, string code, int maxCredits) 
        {
            this.Name = name;
            this.Code = code;
            this.MaxCredits = maxCredits;
            Subjects = new List<Subject>();
        }
    }
}
