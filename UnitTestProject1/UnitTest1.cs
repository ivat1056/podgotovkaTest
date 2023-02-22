using Microsoft.VisualStudio.TestTools.UnitTesting;
using podgotovkaTest;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProduct_Corrcect1()
        {
            int productType = 2;
            int materialType = 2;
            int count = 15;
            float width = (float)20.25;
            float length = (float)40.20;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(actual, typeof(int));
        }
        
        [TestMethod]
        public void GetQuantityForProduct2()
        {
            int productType = 3;
            int materialType = 2;
            int count = 150;
            float width = 2000;
            float length = 4500;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.IsTrue(actual > -2147483648 && actual < 2147483647);
        }
        
        [TestMethod]
        public void GetQuantityForProduct4()
        {
            int productType = 1;
            int materialType = 1;
            int count = 10;
            float width = 5;
            float length = 25;
            int except = 1380;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        
        [TestMethod]
        public void GetQuantityForProduct3()
        {
            int productType = 3;
            int materialType = 1;
            int count = 5;
            float width = 9999999999999999999;
            float length = 9999999999999999999;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.IsTrue(-1 == actual);
        }
       
        [TestMethod]
        public void GetQuantityForProduct5()
        {
            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 0;
            float length = 0;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.AreEqual(0, actual);
        }
       
        [TestMethod]
        public void GetQuantityForProduct6()
        {
            int productType = 500;
            int materialType = 1;
            int count = 5;
            float width = 40;
            float length = 40;
            int except = -1;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        
        [TestMethod]
        public void GetQuantityForProduct7()
        {
            int productType = 2;
            int materialType = 400;
            int count = 5;
            float width = 40;
            float length = 40;
            int except = -1;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }
        
        [TestMethod]
        public void GetQuantityForProduct8()
        {
            int productType = 2;
            int materialType = 2;
            int count = 15;
            float width = -20;
            float length = 30;
            int actual = Class1.GetQuantity(productType, materialType, count, width, length);
            Assert.IsTrue(actual == -1);
        }
    }
}
