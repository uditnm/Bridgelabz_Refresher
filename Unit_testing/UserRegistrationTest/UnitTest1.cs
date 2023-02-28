using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            bool ans = p.CheckFirstName("Udit");
            Assert.IsTrue(ans);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program p = new Program();
            bool ans = p.CheckLastName("Mishra");
            Assert.IsTrue(ans);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Program p = new Program();
            bool ans = p.CheckEmail("abc.xyz@bl.co.in");
            Assert.IsTrue(ans);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Program p = new Program();
            bool ans = p.CheckPhone("91 9919819801");
            Assert.IsTrue(ans);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Program p = new Program();
            bool ans = p.CheckPassword("ABC12#45");
            Assert.IsTrue(ans);
        }
    }
}