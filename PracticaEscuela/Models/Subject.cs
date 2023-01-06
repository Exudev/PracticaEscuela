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

        public string AsingLetterGradePablo(int grade)
        {
            string gradeletter;
            switch (grade)
            {
                case < 60:
                    gradeletter = "F";
                    break;
                case < 70:
                    gradeletter = "D";
                    break;
                case < 75:
                    gradeletter = "C";
                    break;
                case < 80:
                    gradeletter = "C+";
                    break;
                case < 85:
                    gradeletter = "B";
                    break;
                case < 90:
                    gradeletter = "B+";
                    break;
                default:
                    gradeletter = "A";
                    break;
            }
            return gradeletter;


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