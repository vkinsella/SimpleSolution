using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleSolution;

namespace SimpleSolution

{
    [TestFixture]
    class MyTests
    {
   
        [Test]
        public void Test1()
        {
            SimpleProgram sut = new SimpleProgram();

            Assert.AreEqual(5, sut.Add(2, 3));
        }

        [Test]
        public void Test2()
        {
            SimpleProgram sut = new SimpleProgram();

            Assert.AreEqual(6, sut.Add(2, 3));
        }
    }
}
}

