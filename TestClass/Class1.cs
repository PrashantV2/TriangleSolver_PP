using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System.Security.Policy;

namespace TestClass
{
    public class Class1
    {
        // Unit Test case 1 - Equilateral triangle
        // method - Input 1 test
        [Test]
        public void Check_equilateral_Triangle_is_valid()
        {
            //Arrange
            int hypotenuse_side = 8;
            int opposite_side = 8;
            int adjacent_side = 8;


            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);

        }

        // Unit Test case 2 - Isosceles Traingle
        // method - Input 1 test
        [Test]
        public void Check_isosceles_triangle_is_valid_test1()
        {
            //Arrange
            int hypotenuse_side = 8;
            int opposite_side = 8;
            int adjacent_side = 7;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", output);
        }

        // method - Input 2 test
        [Test]
        public void Check_isosceles_triangle_is_valid_test2()
        {
            //Arrange
            int hypotenuse_side = 9;
            int opposite_side = 9;
            int adjacent_side = 8;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES",output);
        }


        // method - Input 3 test
        [Test]

        public void Check_isosceles_triangle_is_valid_test3()
        {
            //Arrange
            int hypotenuse_side = 12;
            int opposite_side = 12;
            int adjacent_side = 8;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES",output);
        }

        // Test case 3 - Scalene
        // method - Input 1 test
        [Test]

        public void Check_scalene_triangle_is_valid_test1()
        {
            //Arrange
            int hypotenuse_side = 20;
            int opposite_side = 40;
            int adjacent_side = 30;


            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE",output);
        }

        // method - Input 2 test
        [Test]

        public void Check_scalene_triangle_is_valid_test2()
        {
            //Arrange
            int hypotenuse_side = 10;
            int opposite_side = 25;
            int adjacent_side = 20;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE",output);
        }

        // method - Input 3 test
        [Test]

        public void Check_scalene_triangle_is_valid_test3()
        {
            //Arrange
            int hypotenuse_side = 18;
            int opposite_side = 23;
            int adjacent_side = 10;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE",output);
        }

        // method - Input 2 test
        [Test]

        public void Check_scalene_triangle_is_valid_test4()
        {
            //Arrange
            int hypotenuse_side = 8;
            int opposite_side = 16;
            int adjacent_side = 12;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE",output);
        }


        // method - Input 5 test
        [Test]

        public void Check_scalene_triangle_is_valid_test5()
        {
            //Arrange
            int hypotenuse_side = 20;
            int opposite_side = 12;
            int adjacent_side = 18;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE",output);
        }

        // Test case 4 - Zero Length Side
        // method - Input 1 test
        [Test]

        public void Check_zeroLengthSide_triangle_is_valid_test1()
        {
            //Arrange
            int hypotenuse_side = 20;
            int opposite_side = 0;
            int adjacent_side = 18;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }
        // method - Input 2 test
        [Test]

        public void Check_zeroLengthSide_triangle_is_valid_test2()
        {
            //Arrange
            int hypotenuse_side = 20;
            int opposite_side = 0;
            int adjacent_side = 0;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }
        // method - Input 3 test
        [Test]

        public void Check_zeroLengthSide_triangle_is_valid_test3()
        {
            //Arrange
            int hypotenuse_side = 0;
            int opposite_side = 0;
            int adjacent_side = 18;

            //Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

    }
}
