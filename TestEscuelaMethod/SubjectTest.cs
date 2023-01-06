namespace TestEscuelaMethod
{
    [TestClass]
    public class SubjectTest
    {
        
        [TestMethod]
        public void TestMethodIsPass()
        {
            //Arrange
            PracticaEscuela.Models.Subject subject = new PracticaEscuela.Models.Subject("Algebra Lineal", "Pipiripiropi", 4);
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
         
            PracticaEscuela.Models.Subject subject = new("Construccion de Software", "IDS420", 4);
            subject.Grade = 100;
            string expected = "A";
            //Act
            subject.GetLetterGrade();
            string actual = subject.LetterGrade;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}