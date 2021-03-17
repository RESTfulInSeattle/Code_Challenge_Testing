using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges.Algorithms;

namespace Code_Tests
{
    [TestClass]
    public class NumIslands_Test
    {
        [TestMethod]
        public void BFS_Test1()
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
            int actual = BFS.NumIslandsBFS(inputGrid);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BFS_Test2()
        {
            //Arrange
            char[,] inputGrid = new char[4, 5]{
                {'1','1','0','0','0' },
                {'1','1','0','0','0' },
                {'0','0','1','0','0' },
                {'0','0','0','1','1' }
            };
            int expected = 3;

            //Assert
            int actual = BFS.NumIslandsBFS(inputGrid);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DFS_Test1()
        {
            //Arrange
            char[,] inputGrid = new char[4, 5]{
                { '1','1','1','1','0' },
                {'1','1','0','1','0' },
                {'1','1','0','0','0' },
                {'0','0','0','0','0' }
            };
            int expected = 1;

            //Assert
            int actual = DFS.NumIslandsDFS(inputGrid);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DFS_Test2()
        {
            //Arrange
            char[,] inputGrid = new char[4, 5]{
                {'1','1','0','0','0' },
                {'1','1','0','0','0' },
                {'0','0','1','0','0' },
                {'0','0','0','1','1' }
            };
            int expected = 3;

            //Assert
            int actual = DFS.NumIslandsDFS(inputGrid);

            Assert.AreEqual(expected, actual);
        }
    }
}
