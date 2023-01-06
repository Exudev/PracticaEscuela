namespace PracticaEscuela.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public decimal Grade { get; set; }
        public string LetterGrade { get; set; }
        public bool Approved { get; set; }
        public DaysOfTheWeek ImpartedDay { get; set; }


        public Subject(string name, string code, int credits, decimal grade,  bool approved)
        {
            Name = name;
            Code = code;
            Credits = credits;
            Grade = grade;
            Approved = approved;

        }
        public Subject(string name, string code, int credits, DaysOfTheWeek impartedDay)
        {
            Name = name;
            Code = code;
            Credits = credits;
            this.ImpartedDay= impartedDay;
        }
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

       

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Friday,
            Saturday
        }
    }
}