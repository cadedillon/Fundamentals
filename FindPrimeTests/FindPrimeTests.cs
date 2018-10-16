using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindPrime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrime.Tests
{
    [TestClass()]
    public class FindPrimeTests
    {
        [TestMethod()]
        public void IsPrimeTest()
        {
            Assert.IsTrue(FindPrime.IsPrime(7));
        }
        [TestMethod()]
        public void IsPrimeTest2()
        {
            Assert.IsFalse(FindPrime.IsPrime(6));
        }
        [TestMethod()]
        public void IsPrimeTest3()
        {
            Assert.IsTrue(FindPrime.IsPrime(5));
        }
        [TestMethod()]
        public void IsPrimeTest4()
        {
            Assert.IsFalse(FindPrime.IsPrime(18));
        }
        [TestMethod()]
        public void IsPrimeTest5()
        {
            Assert.IsTrue(FindPrime.IsPrime(41));
        }
    }
}
