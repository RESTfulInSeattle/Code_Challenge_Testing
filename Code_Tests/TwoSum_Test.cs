using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges.PracticeProblems;

namespace Code_Tests
{
    [TestClass]
    public class TwoSum_Test
    {
        [TestMethod]
        public void Example_1()
        {
            //Arrange
            int[] nums = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = new int[2] { 0, 1 };

            //Act
            int[] actual = TwoSum.TwoSumFunction(nums, target);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Example_2()
        {
            //Arrange
            int[] nums = new int[3] { 3, 2, 4};
            int target = 6;
            int[] expected = new int[2] { 1, 2 };

            //Act
            int[] actual = TwoSum.TwoSumFunction(nums, target);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
