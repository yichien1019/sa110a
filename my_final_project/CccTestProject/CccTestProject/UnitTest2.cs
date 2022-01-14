using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CccTestProject
{
    [TestClass]
    public class TwoTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Console.WriteLine(string.Format("{0} - ClassInitialize", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine(string.Format("{0} - TestInitialize", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }

        [TestMethod]
        public void GetTest()
        {
            Console.WriteLine(string.Format("{0} - Test1", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }

        [TestMethod]
        public void GetTest2()
        {
            Console.WriteLine(string.Format("{0} - Test2", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine(string.Format("{0} - TestCleanup", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            Console.WriteLine(string.Format("{0} - ClassCleanup", TwoMethod.Get()));
            TwoMethod.Now += 1;
        }
    }
}
