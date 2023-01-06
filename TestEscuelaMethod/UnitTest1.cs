namespace TestEscuelaMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetLetterGrad()
        {
            //Arrange
            int grade = 99;
            string expected = "A";
            //Act
            PracticaEscuela.Models.Subject subject = new PracticaEscuela.Models.Subject();
            string actual = subject.AsingLetterGradePablo(grade);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}