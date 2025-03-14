using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges.DataStructures
{
    public class BinarySearchTree
    {
        private Node _root;
        private class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int value)
            {
                Value = value;
                Left = Right = null;
            }
        }

        // 1) Write a function that takes in a list of integers, creates a binary tree with those integers
        public BinarySearchTree(List<int> values)
        {
            if(values == null || values.Count == 0)
            {
                throw new ArgumentNullException("values");
            }

            _root = new Node(values[0]);
            for (int i = 1; i < values.Count; i++)
            {
                Insert(values[i]);
            }
        }

        private void Insert(int value)
        {
            Node currentNode = _root;
            Node newNode = new Node(value);

            while (currentNode != null)
            {
                if (value <= currentNode.Value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        return;
                    }
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        return;
                    }
                    currentNode = currentNode.Right;
                }
            }

            return;
        }

        // 2) Write a function that returns the in-order traversal of the tree as space-separated string.
        public string InOrder()
        {
            return "";
        }

        // 3) Write a function that returns the pre-order traversal of the tree as space-separated string.
        public string PreOrder()
        {
            return "";
        }

        // 4) Write a function that returns the post-order traversal of the tree as space-separated string.
        public string PostOrder()
        {
            return "";
        }

        // 5) Write a function that determines the height of a given tree.
        public int Height()
        {
            return 0;
        }

        // 6) Write a function that returns the sum of all values in a tree.
        public int Sum()
        {
            return 0;
        }

        // 7) Write a function that returns a bool indicating that a value exists (or not) in a given tree.  The test is expecting a capitol True or False.  The Console.WriteLine should convert the bool value to the capitolized version.
        public bool Contains(int value)
        {
            return false;
        }


    }
}
