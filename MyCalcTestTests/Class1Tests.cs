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

        [TestMethod()]
        public void SubTest()
        {
            Class1 cls = new Class1();
            Assert.AreEqual(expected: cls.Sub(3, 7), actual: -4);
        }

        [TestMethod()]
        public void MyStandardTest()
        {
            MyStadard1.Class1 cls = new MyStadard1.Class1();
            Assert.AreEqual(expected: cls.Invoke(1.2, 2.3), actual: 3.5);
        }
    }
}
