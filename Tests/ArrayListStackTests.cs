using System;
using System.Collections.Generic;
using System.Text;
using HerkansingAD;
using Huiswerk2;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class ArrayListStackTests
    {

        [Test]
        public void MyStack_1_Constructor_1_IsEmptyReturnsTrue()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            bool expected = true;

            // Act
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_1_IsEmptyReturnsFalse()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            bool expected = false;

            // Act
            stack.Push(1);
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_2_TopIsOkAfter1Push()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            int expected = 1;

            // Act
            stack.Push(1);
            int actual = stack.Top();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_3_TopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            int expected = 3;

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int actual = stack.Top();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_4_PopIsOkAfter1Push()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            int expected = 1;

            // Act
            stack.Push(1);
            int actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_5_PopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            int expected = 3;

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_6_TwoTimesPopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            int expected = 2;

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            int actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_3_Top_1_ThrowsExceptionOnEmptyStack()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();

            // Act & Assert
            Assert.Throws(typeof(MyStackEmptyException), () => stack.Top());
        }

        [Test]
        public void MyStack_3_Top_2_IsEmptyReturnsFalseAfterTopOnOneElement()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            bool expected = false;

            // Act
            stack.Push(1);
            stack.Top();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_4_Pop_1_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();

            // Act & Assert
            Assert.Throws(typeof(MyStackEmptyException), () => stack.Pop());
        }

        [Test]
        public void MyStack_4_Pop_2_IsEmptyReturnsTrueAfterTopOnOneElement()
        {
            // Arrange
            IMyStack<int> stack = DSBuilder.CreateMyArrayListStack();
            bool expected = true;

            // Act
            stack.Push(1);
            stack.Pop();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
