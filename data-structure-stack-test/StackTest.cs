using System;
using data_structure_stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace data_structure_stack_test
{
    [TestClass]
    public class StackTest
    {


        [TestMethod]
        public void ShouldInstantiateStackObjectOfString()
        {
            Stack<string> stack = new Stack<string>(10);
            Assert.AreNotEqual(stack, null);
            Assert.IsInstanceOfType(stack, typeof(Stack<string>));
            Assert.IsNotInstanceOfType(stack, typeof(Stack<int>));
        }

        [TestMethod]
        public void ShoulInstantiateStackObjectOfInteger()
        {
            Stack<int> stack = new Stack<int>(10);
            Assert.AreNotEqual(stack, null);
            Assert.IsInstanceOfType(stack, typeof(Stack<int>));
            Assert.IsNotInstanceOfType(stack, typeof(Stack<string>));
        }

        [TestMethod]
        public void ShoulInstantiateStackObjectOfObject()
        {
            Stack<object> stack = new Stack<object>(10);
            Assert.AreNotEqual(stack, null);
            Assert.IsInstanceOfType(stack, typeof(Stack<object>));
            Assert.IsNotInstanceOfType(stack, typeof(Stack<string>));
        }

        [TestMethod]
        public void ShouldAdd3ItemsInStackWithLength10()
        {
            Stack<string> stack = new Stack<string>(10);
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            Assert.AreEqual(stack.Top, 2);
        }

        [TestMethod]
        public void ShouldAdd3ItemsInStackWithLength10AndRemoveOneItem()
        {
            Stack<string> stack = new Stack<string>(10);
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            Assert.AreEqual(stack.Top, 2);
            stack.Pop();
            Assert.AreEqual(stack.Top, 1);
        }

        [TestMethod]
        public void ShouldAddMaxLimitItemsInStackWithLength10AndRemoveAllThen()
        {
            int stackLength = 10;
            Stack<string> stack = new Stack<string>(stackLength);
            for (int i = 0; i < 10; i++)
                stack.Push($"Item {i}");

            for (int i = 0; i < 10; i++)
                stack.Pop();

            Assert.AreEqual(stack.Top, -1);
        }

        [TestMethod]
        public void shouldTryToAddItemsInIndexesInAdditionToTheStackSize()
        {
            int stackLength = 10;
            Stack<string> stack = new Stack<string>(stackLength);
            Assert.ThrowsException<IndexOutOfRangeException>(() =>
            {
                for (int i = 0; i <= 10; i++)
                    stack.Push($"Item {i}");
            });
        }
    }
}
