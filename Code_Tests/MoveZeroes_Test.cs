using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges.PracticeProblems;

namespace Code_Tests
{
    [TestClass]
    public class MoveZeroes_Test
    {
        [TestMethod]
        public void ExampleProblem()
        {
            //Arrange
            int[] input = { 0, 1, 0, 3, 12 };
            int[] expected = { 1, 3, 12, 0, 0 };

            //Act
            MoveZeroes.MoveZeroes_Solution(ref input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TwoIndex()
        {
            //Arrange
            int[] input = { 0, 1};
            int[] expected = { 1,0};

            //Act
            MoveZeroes.MoveZeroes_Solution(ref input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void ThreeIndex()
        {
            //Arrange
            int[] input = { 0, 0, 1 };
            int[] expected = { 1,0, 0 };

            //Act
            MoveZeroes.MoveZeroes_Solution(ref input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}
