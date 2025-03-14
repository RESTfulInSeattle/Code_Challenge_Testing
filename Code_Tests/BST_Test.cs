using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Code_Challenges.DataStructures;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Tests
{
    [TestClass]
    class BST_Test
    {

        private static void InOrderTest()
        {

            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            string expected = "3 7 9 10 15 24 36";
            
            Assert.AreEqual(expected, bst.InOrder());
        }

        private static void PreOrderTest()
        {

            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            string expected = "10 7 3 9 15 24 36";
            
            Assert.AreEqual(expected, bst.PreOrder());
        }

        private static void PostOrderTest()
        {
            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            string expected = "3 9 7 36 24 15 10";

            Assert.AreEqual(expected, bst.PostOrder());
        }

        private static void HeightTest()
        {
            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            int expected = 3;

            Assert.AreEqual(expected, bst.Height());
        }

        private static void SumTest()
        {
            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            int expected = 104;

            Assert.AreEqual(expected, bst.Sum());
        }

        private static void ContainsTest()
        {
            var bst = new BinarySearchTree(new List<int> { 10, 15, 7, 9, 3, 24, 36 });

            bool actual = bst.Contains(7);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
