using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEscuela.Models
{
    public class Teacher : Person
    {
        public Carreer Carreer { get; set; }
        public List<Subject> ImpartingSubjects { get; set; }
        public Teacher(string firstName, string lastName, int age, string identification, Carreer carreer)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.age = age;
            this.Identification = identification;
            this.Carreer = carreer;
            this.ImpartingSubjects = new List<Subject>();
        }
        public Teacher() { this.ImpartingSubjects = new List<Subject>(); }
        public void AddSubject(Subject subsub)
        {
            if (ContainsSubject(subsub))
            {
                throw new Exception("Subject is already present");
            }
            else if (SameDayCheck(subsub))
            {
                throw new Exception("Subject is on the same day of another Subject");
            }
            else
            {
                this.ImpartingSubjects.Add(subsub);
            }
        }
        public void DropSubject(Subject subsub)
        {
            if (ContainsSubject(subsub))
            {
                this.ImpartingSubjects.Remove(subsub);
            }
            else { throw new Exception("Subject does not exist"); }
        }
        public bool SameDayCheck(Subject subsub)
        {
            bool sameDay = false;
            if (ImpartingSubjects.Count != 0)
            {
                foreach (Subject subject in ImpartingSubjects)
                {
                    if (subject.ImpartedDay == subsub.ImpartedDay)
                    {
                        sameDay = true;
                    }
                }
            }
            return sameDay;
        }
        public void GradeSubject(Student student, Subject subsub, int grade)
        {
            if (!ContainsSubject(subsub))
            {
                throw new Exception("This subject is not imparted by you");
            }
            else if (!StudentIsOnSubjectCheck(student, subsub))
            {
                throw new Exception("Student is not cursing this subject");
            }
            else
            {
                student.ChosenSubjects.Where(c => c == subsub).ToList().ForEach(c => { c.Grade = grade; });
            }
        }
        public bool StudentIsOnSubjectCheck(Student student, Subject subsub)
        {
            return student.ChosenSubjects.Contains(subsub);
        }
        public bool ContainsSubject(Subject subsub)
        {
            return this.ImpartingSubjects.Contains(subsub);
        }
    }
}
