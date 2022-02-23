using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AbtionIsPresentInString()
        {
            var input = "Abtion only work four days a week";
            // Call class / method;
            var result = "some result";
            var expectedResult = "Not another digital agency";

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AbtionIsNotPresent()
        {
            var input = "I work 5 days a week nine to five";
            // Call class / method;
            var result = "some result";

            var expectedResult = "Not another digital agency";

            Assert.AreNotEqual(expectedResult, result);
        }
    }
}
