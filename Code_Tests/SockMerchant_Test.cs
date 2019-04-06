using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges;

namespace Code_Tests
{
    [TestClass]
    public class SockMerchant_Test
    {
        [TestMethod]
        public void Case8()
        {
            //Arrange
            int[] input = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            int n = 10;
            int expected = 4;

            //Act
            int answer = SockMerchantSolution.SockMerchant(n, input);

            //Assert
            Assert.AreEqual(expected, answer);
        }
    }
}
