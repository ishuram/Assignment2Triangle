using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_Seng8040;
using NUnit.Framework;

namespace Assignment2_Seng8040_Tests
{
    [TestFixture]
    public class Assignment2_Seng8040_Tests
    {
        [Test]
        public void Analyze_Input1And1And1_ReturnsEquilateralTriangle()
        {
            //Arrange
            
            

            //Act
            string actual=TriangleSolver.Analyze(1, 1, 1);

            //Assert
            Assert.AreEqual("Equilateral Triangle", actual);
            
        }

        [Test]
        public void Analyze_Input3And5An7_ReturnsScaleneTriangle()
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(3, 5, 7);

            //Assert
            Assert.AreEqual("Scalene Triangle", actual);

        }
        [Test]
        public void Analyze_Input6And6And11_ReturnsIsoscelesTriangle()
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(6, 6, 11);

            //Assert
            Assert.AreEqual("Isosceles Triangle", actual);

        }
    }
}
