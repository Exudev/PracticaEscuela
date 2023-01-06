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
        public Teacher Teacher { get; set; }


        public Subject(string name, string code, int credits, DaysOfTheWeek impartedDay, Teacher teacher)
        {
            Name = name;
            Code = code;
            Credits = credits;
            this.ImpartedDay = impartedDay;
            this.Teacher = teacher;
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

        public bool IsAValidGrade()
        {
            if(this.Grade <= 100 && this.Grade >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IsPass()
        {
            if (this.Grade >= 70)
            {
                this.Approved = true;
            }
            else
            {
                this.Approved = false;
            }
        }
       

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}