using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges;

namespace Code_Tests
{
    [TestClass]
    public class CountingValleys_Test
    {
        [TestMethod]
        public void Case0()
        {
            //Arrange
            int n = 8;
            string s = "UDDDUDUU";
            int expected = 1;

            //Act
            int answer = CountingValleys.CountingValleysFunction(n, s);

            //Assert
            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void Case1()
        {
            //Arrange
            int n = 12;
            string s = "DDUUDDUDUUUD";
            int expected = 2;

            //Act
            int answer = CountingValleys.CountingValleysFunction(n, s);

            //Assert
            Assert.AreEqual(expected, answer);
        }
    }
}
