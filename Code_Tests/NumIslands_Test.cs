using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges.Algorithms;

namespace Code_Tests
{
    [TestClass]
    public class NumIslands_Test
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            char[,] inputGrid = new char[4,5]{
                { '1','1','1','1','0' },
                {'1','1','0','1','0' },
                {'1','1','0','0','0' },
                {'0','0','0','0','0' }
            };
            int expected = 1;

            //Assert
            int actual = BFS.NumIslands(inputGrid);

            Assert.AreEqual(expected, actual);
        }
    }
}
