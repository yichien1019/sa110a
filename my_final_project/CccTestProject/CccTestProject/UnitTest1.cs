using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    [TestClass()]
    public class OneTests
    {
        [TestMethod()]
        public void Method1Test() //�I�s�����^�ǵ��G��7
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
        public void Method2Test() //�I�s�����^�ǵ��G��10
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
