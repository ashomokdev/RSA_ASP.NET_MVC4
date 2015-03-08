using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSA_lab_2.Controllers;
using System.Numerics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotient()
        {
            Helper h = new Helper();
            Assert.AreEqual(10, Helper.Totient(11));
            Assert.AreEqual(1, Helper.Totient(1));
            Assert.AreEqual(4, Helper.Totient(5));
            Assert.AreEqual(4, Helper.Totient(8));
            Assert.AreEqual(60, Helper.Totient(99));
            Assert.AreEqual(616, Helper.Totient(667));
            Assert.AreEqual(3894912, Helper.Totient(9167368));
        }

        [TestMethod]
        public void GettingValueOfD()
        {
            Assert.AreEqual((BigInteger)6111579, BigInteger.Pow(3, Helper.Totient(9167368) - 1) % 9167368);
            Assert.AreEqual(4, Math.Pow(3, Helper.Totient(11) - 1) % 11);
        }

        [TestMethod]
        public void CheckC()
        {
            Assert.AreEqual(4051753, BigInteger.Pow(111111, 3) % 9173503);
        }
    }
}
