using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseDictionary.Tests
{
    [TestClass()]
    public class MorseEncoderTests
    {
        [TestMethod()]
        public void EncoderTest()
        {
            Assert.AreEqual(".... -.. .-.. .-.. ---   .-- --- .-. .-.. -.-.", MorseEncoder.Encoder("Hello world"));
        }
    }
}