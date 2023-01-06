namespace TestEscuelaMethod
{
    [TestClass]
    public class SubjectTest
    {
        
        [TestMethod]
        public void TestMethodGetLetterGrad()
        {
            //Arrange
            PracticaEscuela.Models.Subject subject = new PracticaEscuela.Models.Subject("Algebra Lineal", "Pipiripiropi", 4, 50, true);
            string expected = "F";
            //Act
            subject.GetLetterGrade();
            string actual = subject.LetterGrade;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodGetLetter()
        {
            //Arrange
         
            PracticaEscuela.Models.Subject subject = new("Construccion de Software", "IDS420", 4, 98 , true);
            string expected = "A";
            //Act
            subject.GetLetterGrade();
            string actual = subject.LetterGrade;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}