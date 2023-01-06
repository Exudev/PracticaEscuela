namespace TestEscuelaMethod
{
    [TestClass]
    public class SubjectTest
    {
        
        [TestMethod]
        public void TestMethodIsPass()
        {
            //Arrange
            PracticaEscuela.Models.Subject subject = new PracticaEscuela.Models.Subject("Algebra Lineal", "Pipiripiropi", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Friday,
                new PracticaEscuela.Models.Teacher());
            subject.Grade = 50;
            bool expected = false;
            //Act
            subject.IsPass();
            bool actual = subject.Approved;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodGetLetter()
        {
            //Arrange
         
            PracticaEscuela.Models.Subject subject = new("Construccion de Software", "IDS420", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday,
                new PracticaEscuela.Models.Teacher());
            subject.Grade = 100;
            string expected = "A";
            //Act
            subject.GetLetterGrade();
            string actual = subject.LetterGrade;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodValidGrade()
        {
            //Arrange
            PracticaEscuela.Models.Subject subject = new PracticaEscuela.Models.Subject("Redaccion", "ESO240", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Monday,
                new PracticaEscuela.Models.Teacher());
            subject.Grade = 120;
            bool expected = false;
            //Act
            bool actual = subject.IsAValidGrade();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}