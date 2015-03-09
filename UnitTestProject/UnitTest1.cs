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
        public void CheckC()
        {
            Assert.AreEqual(4051753, BigInteger.Pow(111111, 3) % 9173503);
        }

        [TestMethod]
        public void MultiplicativeInverseCheck()
        {
            Assert.AreEqual(Helper.MultiplicativeInverse(3, 9167368), 6111579);
        }
    }
}
