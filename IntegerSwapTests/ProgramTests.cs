using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerSwap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap.Tests
{
    [TestClass()]
    public class IntegerSwapTests
    {
        [TestMethod()]
        public void IntegerSwapTest1()
        {
            Assert.AreEqual("2, 3", IntegerSwap.IntSwap(3, 2));
        }
        [TestMethod()]
        public void IntegerSwapTest2()
        {
            Assert.AreEqual("-2, -3", IntegerSwap.IntSwap(-3, -2));
        }
        [TestMethod()]
        public void IntegerSwapTest3()
        {
            Assert.AreEqual("0, 3", IntegerSwap.IntSwap(3, 0));
        }
        [TestMethod()]
        public void IntegerSwapTest4()
        {
            Assert.AreEqual("732432, 78687", IntegerSwap.IntSwap(78687, 732432));
        }
    }
}