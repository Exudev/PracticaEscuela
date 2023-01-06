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
        public string LetterGrade { get; set; }
        public bool Approved { get; set; }
        public DaysOfTheWeek ImpartedDay { get; set; }
        public void GetLetterGrade()
        {
            switch (this.Grade) 
            {
                case < 60:
                    this.LetterGrade = "F";
                    break;
                case < 70:
                    this.LetterGrade = "D";
                    break;
                case < 75:
                    this.LetterGrade = "C";
                    break;
                case < 80:
                    this.LetterGrade = "C+";
                    break;
                case < 85:
                    this.LetterGrade = "B";
                    break;
                case < 90:
                    this.LetterGrade = "B+";
                    break;
                default:
                    this.LetterGrade = "A";
                    break;
            }
        }
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
