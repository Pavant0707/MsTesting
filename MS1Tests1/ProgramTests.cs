using Microsoft.VisualStudio.TestTools.UnitTesting;
using MS1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Array a=new Array();
        [TestMethod()]
        public void AddTest()
        {
            int result = a.Add();
            int ex = 10;
            Assert.AreEqual(ex, result);
        }
        [TestMethod()]
        public void AddTest1()
        {
            int result = a.Add();
            int ex = 1;
            Assert.AreEqual(ex, result);
        }

        [TestMethod()]
        public void AddTest2()
        {
            bool result = a.Contains1("teja");
            //string ex = "true";
            Boolean ex=true;
            Assert.AreEqual(ex, result);
        }
        [TestMethod()]
        public void AddTest3()
        {
            string result = a.upercase("aaa");
            string exe = "AAA";
            Assert.AreEqual(exe, result);
        }
        [TestMethod()]
        public void AddTest4()
        {
            string result = a.substring("king", "virat");
            String exe = "hi king virat";
            Assert.AreEqual(exe, result);
        }
    }
}