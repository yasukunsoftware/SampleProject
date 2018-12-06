using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcTest.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            Class1 cls = new Class1();
            Assert.AreEqual(cls.Add(2, 3), 5);
        }
    }
}