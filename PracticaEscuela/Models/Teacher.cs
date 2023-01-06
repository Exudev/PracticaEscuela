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
    }
}
