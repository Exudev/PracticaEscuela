using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEscuela.Models
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public decimal Grade { get; set; }
        public bool Approved { get; set; }
        public DaysOfTheWeek ImpartedDay { get; set; }
    }
    enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday
    }
}
