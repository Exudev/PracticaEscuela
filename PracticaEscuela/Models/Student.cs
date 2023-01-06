namespace PracticaEscuela.Models
{
    internal class Student : Person
    {
        public Student(Carreer chosenCarreer) { this.Carreer = chosenCarreer; }
        public Carreer Carreer { get; set; }
        public List<Subject> ChosenSubjects { get; set; }

        public void AddSubject(Subject subsub)
        {
            if (ContainsSubject(subsub))
            {
                throw new Exception("Subject is already present");
            }
            else
            {
                this.ChosenSubjects.Add(subsub);
            }
        }
        public void DropSubject(Subject subsub)
        {
            if (ContainsSubject(subsub))
            {
                this.ChosenSubjects.Remove(subsub);
            }
            else { throw new Exception("Subject does not exist"); }
        }
        public bool ContainsSubject(Subject subsub)
        {
            return this.ChosenSubjects.Contains(subsub);
        }
    }
}
