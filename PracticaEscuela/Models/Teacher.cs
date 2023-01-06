namespace PracticaEscuela.Models
{
    internal class Teacher : Person
    {
        public Carreer Carreer { get; set; }
        public List<Subject> ImpartingSubjects { get; set; }
    }
}
