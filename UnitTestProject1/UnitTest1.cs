using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTests; 
using System;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestSumOfPositiveValues()
        {
            LinkedList list = new LinkedList();
            list.Add(2);
            list.Add(-5);
            list.Add(10);
            list.Add(7);
            list.Add(-3);

            int sumOfPositives = SumOfPositiveValuesRecursive(list.Head);

            Assert.AreEqual(19, sumOfPositives);
        }

        private int SumOfPositiveValuesRecursive(ListNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int sum = SumOfPositiveValuesRecursive(node.Next);
            if (node.Value > 0)
            {
                sum += node.Value;
            }
            return sum;
        }

        private int SumOfPositiveValuesRecursive(Node node)
        {
            if (node == null)
                return 0;

            int nextSum = SumOfPositiveValuesRecursive(node.Next);

            if (node.Data > 0)
                return node.Data + nextSum;
            else
                return nextSum;
        }

        private int SumOfPositiveValuesRecursive(object next)
        {
            throw new NotImplementedException();
        }
    }

    internal class Node
    {
        public int Data { get; internal set; }
        public ListNode Next { get; internal set; }
    }
}
