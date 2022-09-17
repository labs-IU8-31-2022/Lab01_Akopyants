using LABASHARP1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLABASHARP1
{
    [TestClass]
    public class UnitTest_Task2
    {
        [TestMethod]
        public void Test_Task2_1()
        {
            Rectangle Test_Area = new Rectangle(5, 7);
            double expected = 35;
            Assert.AreEqual(expected, Test_Area.Area); 
        }

        [TestMethod]
        public void Test_Task2_2()
        {
            Rectangle Test_Area = new Rectangle(-5, 7);
            double expected = 35;
            Assert.AreEqual(expected, Test_Area.Area); 
        }

        [TestMethod]
        public void Test_Task2_3()
        {
            Rectangle Test_Area = new Rectangle(0, 7);
            double expected = 0;
            Assert.AreEqual(expected, Test_Area.Area); 
        }

        [TestMethod]
        public void Test_Task2_4()
        {
            Rectangle Test_Perimetr = new Rectangle(1, 7);
            double expected = 16;
            Assert.AreEqual(expected, Test_Perimetr.Perimeter); 
        }

        [TestMethod]
        public void Test_Task2_5()
        {
            Rectangle Test_Perimetr = new Rectangle(0, 7);
            double expected = 14;
            Assert.AreEqual(expected, Test_Perimetr.Perimeter);
        }

        [TestMethod]
        public void Test_Task2_6()
        {
            Rectangle Test_Perimetr = new Rectangle(0, -7);
            double expected = 14;
            Assert.AreEqual(expected, Test_Perimetr.Perimeter);
        }

        [TestMethod]
        public void Test_Task3_1()
        {
            Point obj1 = new Point(5, 6);
            Point obj2 = new Point(8, 10);
            Point obj3 = new Point(3, 9);
            Figure Test_Length = new Figure(obj1, obj2, obj3);
            double expected = 13.704570789056774;
            Assert.AreEqual(expected, Test_Length.PerimeterCalculator());
            
        }
        [TestMethod]
        public void Test_Task3_2()
        {
            Point obj1 = new Point(5, 6);
            Point obj2 = new Point(8, 10);
            Point obj3 = new Point(3, 9);
            Figure Test_Length = new Figure(obj1, obj2, obj3);
            double expected = 5;
            Assert.AreEqual(expected, Test_Length.get_length(obj1,obj2));

        }
    }

}
