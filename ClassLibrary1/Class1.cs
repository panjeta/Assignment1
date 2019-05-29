using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp16;
using NUnit.Framework;

namespace RectangleTest
{
    [TestFixture]
    public class Rectangle
    {


        [Test]
        public void GetLength_Input12_Returns12()
        {

            //Arrange
            int length = 12;
            int width = 10;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetWidth_Input30_Returns30()
        {

            //Arrange
            int length = 10;
            int width = 30;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetLength_Input15_Returns15()
        {

            //Arrange
            int length = 15;
            int width = 12;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Setwidth_Input40_Returns40()
        {

            //Arrange
            int length = 65;
            int width = 40;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetPerimeter_Input_Length8And_Width9_Returns34()
        {

            //Arrange
            int length = 8;
            int width = 9;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input_Length4And_Width5_Returns20()
        {

            //Arrange
            int length = 4;
            int width = 5;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}


