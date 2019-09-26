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
        public void Analyze_Input1And1And1_ReturnsEquilateralTriangle()//unit test1-checks for equilateral triangle
        {
            //Arrange
            
            

            //Act
            string actual=TriangleSolver.Analyze(1, 1, 1);

            //Assert
            Assert.AreEqual("Equilateral Triangle", actual);
            
        }

        [Test]
        public void Analyze_Input3And5An7_ReturnsScaleneTriangle()//unit test2-checks for scalene triangle
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(3, 5, 7);

            //Assert
            Assert.AreEqual("Scalene Triangle", actual);

        }
        [Test]
        public void Analyze_Input6And6And11_ReturnsIsoscelesTriangle()//unit test3-checks for isosceles triangle where side1=side2
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(6, 6, 11);

            //Assert
            Assert.AreEqual("Isosceles Triangle", actual);

        }
        [Test]
        public void Analyze_Input1And2And3_ReturnsCannotFormTriangle()//unit test4-checks for invald triangle where side3>side2>side1
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(1, 2, 3);

            //Assert
            Assert.AreEqual("Cannot form triangle", actual);

        }

        [Test]
        public void Analyze_Input8And4And3_ReturnsCannotFormTriangle()//unit test5-checks for invalid triangle where side1>side2>side1
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(8, 4, 3);

            //Assert
            Assert.AreEqual("Cannot form triangle", actual);

        }
        [Test]
        public void Analyze_Input99And99And1_ReturnsIsoscelesTriangle()//unit test6-checks for isosceles triangle where side1 and side2 are much greater(99) than side3
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(99, 99, 1);

            //Assert
            Assert.AreEqual("Isosceles Triangle", actual);

        }
        [Test]
        public void Analyze_Input6And11And5_ReturnsCannotFormTriangle()//unit test7-checks for invalid triangle where side2>side1>side3
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(6, 11, 5);

            //Assert
            Assert.AreEqual("Cannot form triangle", actual);

        }
        [Test]
        public void Analyze_Input101And2And101_ReturnsCannotFormTriangle()//unit test8-checks for isosceles triangle where side1=side3
        {
            //Arrange



            //Act
            string actual = TriangleSolver.Analyze(101, 2, 101);

            //Assert
            Assert.AreEqual("Isosceles Triangle", actual);

        }

    }
}
