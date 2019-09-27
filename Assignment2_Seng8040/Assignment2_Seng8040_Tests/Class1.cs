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
            int side1 = 1;
            int side2 = 1;
            int side3 = 1;

            string expected = "A triangle is formed. This is an Equilateral Triangle";

            //Act
            string actual=TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [Test]
        public void Analyze_Input3And5An7_ReturnsScaleneTriangle()//unit test2-checks for scalene triangle
        {
            //Arrange
            int side1 = 3;
            int side2 = 5;
            int side3 = 7;
            string expected = "A triangle is formed. This is a Scalene Triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Analyze_Input6And6And11_ReturnsIsoscelesTriangle()//unit test3-checks for isosceles triangle where side1=side2
        {
            //Arrange
            int side1 = 6;
            int side2 = 6;
            int side3 = 11;
            string expected = "A triangle is formed. This is an Isosceles Triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Analyze_Input1And2And3_ReturnsCannotFormTriangle()//unit test4-checks for invald triangle where side3>side2>side1
        {
            //Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 3;
            string expected = "Cannot form triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Analyze_Input9And4And3_ReturnsCannotFormTriangle()//unit test5-checks for invalid triangle where side1>side2>side1
        {
            //Arrange
            int side1 = 9;
            int side2 = 4;
            int side3 = 3;
            string expected = "Cannot form triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Analyze_Input99And99And1_ReturnsIsoscelesTriangle()//unit test6-checks for isosceles triangle where side1 and side2 are much greater(99) than side3
        {
            //Arrange
            int side1 = 99;
            int side2 = 99;
            int side3 = 1;
            string expected = "A triangle is formed. This is an Isosceles Triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Analyze_Input6And11And5_ReturnsCannotFormTriangle()//unit test7-checks for invalid triangle where side2>side1>side3
        {
            //Arrange

           int side1 = 6;
            int side2 = 11;
            int side3 = 5;

            string expected = "Cannot form triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Analyze_Input101And2And101_ReturnsIsoscelesTriangle()//unit test8-checks for isosceles triangle where side1=side3
        {
            //Arrange
            int side1 = 101;
            int side2 = 2;
            int side3 = 101;
            string expected = "A triangle is formed. This is an Isosceles Triangle";

            //Act
            string actual = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
