using System;
namespace StackAndQueue
{
    internal class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void Push(int data)
        {
            linkedList.AddNode(data);
        }
        public void DisplayStack()
        {
            Console.WriteLine("Stack elements are");
            linkedList.Display();
        }
    }
}