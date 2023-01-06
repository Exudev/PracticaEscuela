using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEscuela.Models
{
    internal class Student : Person
    {
        public Carreer Carreer { get; set; }
        public List<Subject> ChosenSubjects { get; set; }
    }
}
