using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    [TestClass()]
    public class MyCode2Test
    {
        public int a, b;
        [TestMethod()]
        
        public void AddnumTest()
        {

            //assert
            var Sut = new MyCode2();
            var expected = 15;
            
            //arrange
            var actual = Sut.Addnum(10,5);
            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubnumTest()
        {
            //assert
            var Sut = new MyCode2();
            var expected = 5;

            //arrange
            var actual = Sut.Subnum(10,5);
            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultnumTest()
        {
            //assert
            var Sut = new MyCode2();
            var expected = 50;

            //arrange
            var actual = Sut.Multnum(10,5);
            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivnumTest()
        {
            //assert
            var Sut = new MyCode2();
            var expected = 2;

            //arrange
            var actual = Sut.Divnum(10,5);
            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ModnumTest()
        {
            //assert
            var Sut = new MyCode2();
            var expected = 0;

            //arrange
            var actual = Sut.Modnum(10,5);
            //act
            Assert.AreEqual(expected, actual);
        }
    }
    
}
