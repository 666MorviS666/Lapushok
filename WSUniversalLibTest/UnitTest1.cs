using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int productType = 1;
            int materialType = 1;
            int count = 0;
            float width = 20;
            float length = 10;
            Calculation vv = new Calculation();
            int ss = vv.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(ss);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType_2()
        {
            int productType = 2;
            int materialType = 15;
            int count = 0;
            float width = 50;
            float length = 10;
            Calculation vv = new Calculation();
            int ss = vv.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(ss);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType_3()
        {
            int productType = 2;
            int materialType = 15;
            int count = 0;
            float width = 50;
            float length = 10;
            Calculation vv = new Calculation();
            int yy = 10;
            int ss = vv.GetQuantityForProduct(productType, materialType, count, width, length);
            CollectionAssert.Equals(ss, yy);
        }
    }
}
