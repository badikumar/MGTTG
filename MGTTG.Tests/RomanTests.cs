using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MGTTG.Tests
{
    [TestClass]
    public class RomanTests
    {
        [TestMethod]
        public void Convert1()
        {
            var r = new Roman("I");
            var i = r.ToInt();
            Assert.AreEqual(1,i);
        }

        [TestMethod]
        public void Convert2()
        {
            var r = new Roman("II");
            var i = r.ToInt();
            Assert.AreEqual(2, i);
        }

        [TestMethod]
        public void Convert3()
        {
            var r = new Roman("III");
            var i = r.ToInt();
            Assert.AreEqual(3, i);
        }

        [TestMethod]
        public void Convert4()
        {
            var r = new Roman("IV");
            var i = r.ToInt();
            Assert.AreEqual(4, i);
        }
        [TestMethod]
        public void Convert5()
        {
            var r = new Roman("V");
            var i = r.ToInt();
            Assert.AreEqual(5, i);
        }

        [TestMethod]
        public void Convert6()
        {
            var r = new Roman("VI");
            var i = r.ToInt();
            Assert.AreEqual(6, i);
        }

        [TestMethod]
        public void Convert7()
        {
            var r = new Roman("VII");
            var i = r.ToInt();
            Assert.AreEqual(7, i);
        }


        [TestMethod]
        public void Convert8()
        {
            var r = new Roman("VIII");
            var i = r.ToInt();
            Assert.AreEqual(8, i);
        }

        [TestMethod]
        public void Convert9()
        {
            var r = new Roman("IX");
            var i = r.ToInt();
            Assert.AreEqual(9, i);
        }

        [TestMethod]
        public void Convert10()
        {
            var r = new Roman("X");
            var i = r.ToInt();
            Assert.AreEqual(10, i);
        }

        [TestMethod]
        public void Convert39()
        {
            var r = new Roman("XXXIX");
            var i = r.ToInt();
            Assert.AreEqual(39, i);
        }

        [TestMethod]
        public void Convert1903()
        {
            var r = new Roman("MCMIII");
            var i = r.ToInt();
            Assert.AreEqual(1903, i);
        }
        
        [TestMethod]
        public void Convert1944()
        {
            var r = new Roman("MCMXLIV");
            var i = r.ToInt();
            Assert.AreEqual(1944, i);
        }
    }
}
