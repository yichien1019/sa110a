using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    [TestClass()]
    public class OneTests
    {
        [TestMethod()]
        public void Method1Test() //呼叫時應回傳結果為7
        {
            //assert
            var Sut = new OneMethod();
            var expected = 7;

            //arrange
            var actual = Sut.Method1();

            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Method2Test() //呼叫時應回傳結果為10
        {
            //assert
            var Sut = new OneMethod();
            var expected = 10;

            //arrange
            var actual = Sut.Method2();

            //act
            Assert.AreEqual(expected, actual);
        }
    }
}
