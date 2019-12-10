using System;
using System.Collections.Generic;
using System.Text;
using HerkansingAD;
using Huiswerk2;
using NUnit.Framework;

namespace Tests
{
    class ArrayQueueTests
    {
        [TestFixture]
        public class Ex5MyQueueTests
        {
            [Test]
            public void MyQueue_1_Constructor_1_IsEmptyReturnsTrue()
            {
                // Arrange
                IMyQueue<string> q = DSBuilder.CreateMyArrayQueue();
                bool expected = true;

                // Act
                bool actual = q.IsEmpty();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_1_IsEmptyReturnsFalse()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                bool expected = false;

                // Act
                stack.Enqueue("a");
                bool actual = stack.IsEmpty();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_2_GetFrontIsOkAfter1Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "a";

                // Act
                stack.Enqueue("a");
                string actual = stack.GetFront();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_3_GetFrontIsOkAfter3Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "a";

                // Act
                stack.Enqueue("a");
                stack.Enqueue("b");
                stack.Enqueue("c");
                string actual = stack.GetFront();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_3_GetBackIsOkAfter3Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "c";

                // Act
                stack.Enqueue("a");
                stack.Enqueue("b");
                stack.Enqueue("c");
                string actual = stack.GetBack();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_4_DequeueIsOkAfter1Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "a";

                // Act
                stack.Enqueue("a");
                string actual = stack.Dequeue();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_5_DequeueIsOkAfter3Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "a";

                // Act
                stack.Enqueue("a");
                stack.Enqueue("b");
                stack.Enqueue("c");
                string actual = stack.Dequeue();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_2_Enqueue_6_TwoTimesDequeueIsOkAfter3Enqueue()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                string expected = "b";

                // Act
                stack.Enqueue("a");
                stack.Enqueue("b");
                stack.Enqueue("c");
                stack.Dequeue();
                string actual = stack.Dequeue();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_3_GetBack_1_ThrowsExceptionOnEmptyStack()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();

                // Act & Assert
                Assert.Throws(typeof(MyQueueEmptyException), () => stack.GetBack());
            }

            [Test]
            public void MyQueue_3_GetBack_2_IsEmptyReturnsFalseAfterGetBackOnOneElement()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                bool expected = false;

                // Act
                stack.Enqueue("a");
                stack.GetBack();
                bool actual = stack.IsEmpty();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_3_GetFront_1_ThrowsExceptionOnEmptyStack()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();

                // Act & Assert
                Assert.Throws(typeof(MyQueueEmptyException), () => stack.GetFront());
            }

            [Test]
            public void MyQueue_3_GetFront_2_IsEmptyReturnsFalseAfterGetFrontOnOneElement()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                bool expected = false;

                // Act
                stack.Enqueue("a");
                stack.GetFront();
                bool actual = stack.IsEmpty();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void MyQueue_4_Dequeue_1_ThrowsExceptionOnEmptyList()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();

                // Act & Assert
                Assert.Throws(typeof(MyQueueEmptyException), () => stack.Dequeue());
            }

            [Test]
            public void MyQueue_4_Dequeue_2_IsEmptyReturnsTrueAfterGetFrontOnOneElement()
            {
                // Arrange
                IMyQueue<string> stack = DSBuilder.CreateMyArrayQueue();
                bool expected = true;

                // Act
                stack.Enqueue("a");
                stack.Dequeue();
                bool actual = stack.IsEmpty();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
