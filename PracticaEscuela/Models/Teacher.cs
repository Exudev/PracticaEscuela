using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEscuela.Models
{
    internal class Teacher : Person
    {
        public Carreer Carreer { get; set; }
        public List<Subject> ImpartingSubjects { get; set; }

        public void AddSubject(Subject subsub)
        {
            if (ContainsSubject(subsub) && SameDayCheck(subsub))
            {
                throw new Exception("Subject is already present");
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
        public bool ContainsSubject(Subject subsub)
        {
            return this.ImpartingSubjects.Contains(subsub);
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

    }


}
