using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code_Challenges;

namespace Code_Tests
{
    [TestClass]
    public class ArrayIntersection_Test
    {
            [TestMethod]
            public void Example_1()
            {
                //Arrange
                int[] nums1 = new int[4] { 1, 2, 2, 1 };
                int[] nums2 = new int[2] {2, 2};
                int[] expected = new int[1] { 2 };

                //Act
                int[] actual = ArrayIntersection.Intersection(nums1, nums2);

                //Assert
                CollectionAssert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Example_2()
            {
                //Arrange
                int[] nums1 = new int[3] { 4, 9, 5};
                int[] nums2 = new int[5] { 9, 4, 9, 8, 4};
                int[] expected = new int[2] { 9,4 };

                //Act
                int[] actual = ArrayIntersection.Intersection(nums1, nums2);

                //Assert
                CollectionAssert.AreEqual(expected, actual);
            }
    }
}
