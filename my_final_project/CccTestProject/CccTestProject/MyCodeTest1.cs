using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    public class MyCodeTest1
    {
        [TestClass()]
        public class MyTests1
        {
            [TestMethod()]
            public void ReverseTest1()   //測試小寫轉大寫
            {
                //Arrange
                var ex = new MyCode1();
                var input = "abc";

                //Act
                var actual = ex.Reverse(input);

                //Assert
                var expected = "cba";
                Assert.AreEqual(expected, actual);
            }
        }
        public class ExampleTests2
        {
            [TestMethod()]
            public void ReverseTest2()
            {
                //Arrange
                var ex = new MyCode1();
                var input = "ABC";

                //Act
                var actual = ex.Reverse(input);

                //Assert
                var expected = "CBA";
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
