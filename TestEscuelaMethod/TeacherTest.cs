using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaEscuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEscuelaMethod
{
    [TestClass]
    public class TeacherTest
    {
        [TestMethod]
        //A teacher can't have 2 subjects on the same day
        public void AddSubjectOnSameDay()
        {
            //Arrange
            PracticaEscuela.Models.Teacher teacher = new PracticaEscuela.Models.Teacher("Carmen", "Montero", 25, "402-10358945-9",
                new PracticaEscuela.Models.Carreer("Ingenieria de Software", "IDS", 21));
            teacher.AddSubject(new PracticaEscuela.Models.Subject("Construccion de software", "IDSAlgo", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday));
            teacher.AddSubject(new PracticaEscuela.Models.Subject("Laboratorio de Construccion de software", "IDSAlgoL", 1, PracticaEscuela.Models.Subject.DaysOfTheWeek.Wednesday));
            //Act
            var exception = Assert.ThrowsException<Exception>(() => 
            teacher.AddSubject(new PracticaEscuela.Models.Subject("Arquitectura de software", "IDSMucho", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday)));
            //Assert
            Assert.AreSame(exception.Message, "Subject is on the same day of another Subject");
        }
        [TestMethod]
        public void SubjectAlreadyExists()
        {
            //Arrange
            PracticaEscuela.Models.Teacher teacher = new PracticaEscuela.Models.Teacher("Carmen", "Montero", 25, "402-10358945-9",
                new PracticaEscuela.Models.Carreer("Ingenieria de Software", "IDS", 21));
            Subject ConstruccionSoftware = new Subject("Construccion de software", "IDSAlgo", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday);
            teacher.AddSubject(ConstruccionSoftware);
            //Act
            var exception = Assert.ThrowsException<Exception>(() =>
            teacher.AddSubject(ConstruccionSoftware));
            //Assert
            Assert.AreSame(exception.Message, "Subject is already present");
        }
        [TestMethod]
        public void DropSubjectNotRegistered()
        {
            //Arrange
            PracticaEscuela.Models.Teacher teacher = new PracticaEscuela.Models.Teacher("Carmen", "Montero", 25, "402-10358945-9",
               new PracticaEscuela.Models.Carreer("Ingenieria de Software", "IDS", 21));
            Subject ConstruccionSoftware = new Subject("Construccion de software", "IDSAlgo", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday);
            Subject LabConstruccion = new Subject("Laboratorio de Construccion de software", "IDSAlgoL", 1, PracticaEscuela.Models.Subject.DaysOfTheWeek.Wednesday);
            teacher.AddSubject(ConstruccionSoftware);
            //Act
            var exception = Assert.ThrowsException<Exception>(() =>
            teacher.DropSubject(LabConstruccion));
            //Assert
            Assert.AreSame(exception.Message, "Subject does not exist");
        }
        [TestMethod]
        public void DropExistingSubject()
        {
            //Arrange
            PracticaEscuela.Models.Teacher teacher = new PracticaEscuela.Models.Teacher("Carmen", "Montero", 25, "402-10358945-9",
               new PracticaEscuela.Models.Carreer("Ingenieria de Software", "IDS", 21));
            Subject ConstruccionSoftware = new Subject("Construccion de software", "IDSAlgo", 4, PracticaEscuela.Models.Subject.DaysOfTheWeek.Tuesday);
            //Act
            teacher.AddSubject(ConstruccionSoftware);
            teacher.DropSubject(ConstruccionSoftware);
            //Asser
            Assert.AreEqual(teacher.ImpartingSubjects.Count, 0);
        }
    }
}
