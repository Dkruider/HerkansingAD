using System.Collections.Generic;
using System.Text.RegularExpressions;
using HerkansingAD;
using Huiswerk6;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GraphTests
    {
        private string StringWithoutSpaces(string s)
        {
            return Regex.Replace(s, @"\s+", "").Trim();
        }

        [Test]
        public void Graph_ToString_OnEmptyGraph()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraphEmpty();
            string expected = "";

            // Act
            string actual = StringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);


            Assert.Pass();
        }

        [Test]
        public void Graph_ToString_OnGraph14_1()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraph14_1();
            string expectedWithSpaces = StringWithoutSpaces("V0 [ V1(2) V3(1) ] V1 [ V3(3) V4(10) ] V2 [ V0(4) V5(5) ] V3 [ V2(2) V5(8) V6(4) V4(2) ] V4 [ V6(6) ] V5 V6 [ V5(1) ]");
            string expected = StringWithoutSpaces(expectedWithSpaces);

            // Act
            string actual = StringWithoutSpaces(graph.ToString());

            // Assert
            Assert.AreEqual(expected, actual);


            Assert.Pass();
        }

        [Test]
        public void Graph_IsConnected_OnConnectedGraph()
        {
            // Arrange
            IGraph graph = DSBuilder.ConnectedGraph();

            // Act
            bool actual = graph.IsConnected();

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Graph_IsConnected_OnNotConnectedGraph()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraph14_1();

            // Act
            bool actual = graph.IsConnected();

            // Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void Graph_ClearAll_AllVerticesDefaultValues()
        {
            // Arrange
            IGraph graph = DSBuilder.CreateGraph14_1();

            // Act
            graph.ClearAll();
            List<Vertex> vertices = graph.GetAllVertices();
            bool actual = false;

            foreach (Vertex vertex in vertices)
            {
                if (vertex.Dist.Equals(Graph.INFINITY) && !vertex.Known && vertex.Prev == null) actual = true;
                else
                {
                    actual = false;
                    break;
                };
            }

            // Assert
            Assert.IsTrue(actual);
        }
    }
}