using System.Collections.Generic;
using Xunit;

namespace PlayGround.Tests
{
    public class AdvancedCollectionsTests
    {
        [Fact]
        public void LinkedLists() 
        {
            var list = new LinkedList<string>();

            var node1 = new LinkedListNode<string>("A");
            var node3 = new LinkedListNode<string>("C");
            var node2 = new LinkedListNode<string>("B");

            list.AddFirst(node2);
            list.AddAfter(node2, node1);
            list.AddAfter(node1, node3);

            var node4 = new LinkedListNode<string>("D");

            list.AddLast(node4);

            Assert.Equal("B", list.First.Value);
            Assert.Equal("C", list.Find("C").Value);
            Assert.Null(list.Find("E"));
        }

        [Fact]
        public void Stacks() 
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            stack.Pop();

            var topElement = stack.Peek();

            Assert.Equal(3, stack.Count);
            Assert.Equal("c", topElement);
        }

        [Fact]
        public void Queues() 
        {
            var queue = new Queue<(string ticketNumber, string personName)>();

            queue.Enqueue(("ticket1", "Pepe"));
            queue.Enqueue(("ticket2", "Carlitos"));
            queue.Dequeue();

            queue.TryPeek(out var ticketInfo);

            Assert.Single(queue);
            Assert.Equal("Carlitos", ticketInfo.personName);
        }
    }
}