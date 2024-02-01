using get_set_Ex1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace unitTestStudent
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentDefault()
        {
            //Arrange

            // Act
            Student alfond = new Student();

            // Assert
            Assert.IsNotNull(alfond, "Alfond doit être un etudiant");
        }

        [TestMethod]
        public void TestStudentAllParams()
        {
            // Arrange
            string lastName = "Alfond";
            string firstName = "Alexandre";
            int studentNumber = 1001;
            string classTeacher = "ACD";
            string login = "alfondal";
            double grade1 = 4;
            double grade2 = 4.5;
            double grade3 = 5;

            // Act
            Student alfond = new Student(lastName, firstName, studentNumber, classTeacher,
             login,  grade1,  grade2, grade3);

            //Assert 
            Assert.IsNotNull(alfond, "Alfond doit être un etudiant");
        }

        [TestMethod]
        public void TestAverrage()
        {
            // Arrange
            double grade1 = 4;
            double grade2 = 4.5;
            double grade3 = 5;
            Student alfond = new Student();
            alfond.Grade1 = grade1;
            alfond.Grade2 = grade2;
            alfond.Grade3 = grade3;

            // Act
            alfond.Average();

            // Assert
            Assert.AreEqual(4.5, alfond.Average(), "La moyenne de Alfond doit être de 4,5");
        }

        [TestMethod]
        public void TestStatusReusite()
        {
            // Arrange 
            double average = 4.5;
            Student alfond = new Student();
            string result = null;
            // Act
            result = alfond.Status(average);

            // Assert
            Assert.AreEqual("En réussite", result, "Alfond doit être en réussite");
        }

        [TestMethod]
        public void TestStatusEchec()
        {
            // Arrange 
            Student alfond = new Student();
            double average = 0;
            double grade1 = 3.5;
            double grade2 = 0;
            double grade3 = 3.5;
            alfond.Grade1 = grade1;
            alfond.Grade2 = grade2;
            alfond.Grade3 = grade3;
            average = alfond.Average();

            string result = null;
            // Act
            result = alfond.Status(average);

            // Assert
            Assert.AreEqual("En échec", result, "Alfond doit être en échec");

        }

    }
}
