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
            // Arrange
            int hypotenuse_side = 8;
            int opposite_side = 8;
            int adjacent_side = 8;


            // Act
            string output = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);
        }

    }
}
