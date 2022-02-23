using AbtionUclTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbtionUclUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private TestClass _sut;

        public UnitTest1()
        {
            _sut = new TestClass();
        }

        [TestMethod]
        public void AbtionIsPresentInString()
        {
            var input = "Abtion only work four days a week";

            var result = _sut.OurMethod(input);
            
            var expectedResult = "Not another digital agency";

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbtionIsNotPresent()
        {
            var input = "I work 5 days a week nine to five";

            var result = _sut.OurMethod(input);

            var expectedResult = "Not another digital agency";

            Assert.AreNotEqual(expectedResult, result);
        }
    }
}