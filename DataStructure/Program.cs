using System;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Custom Linked List";
            //var list = new CustomLinkedList<string>();
            //list.Add("Hello");
            //list.Add("world");
            //list.Add("from");
            //list.Add("my");
            //list.Add("LinkedList");
            //list.Traverse(s => Console.Write($"{s} "));
            //list.Remove("my");
            //Console.WriteLine();
            //list.Traverse(s => Console.Write($"{s} "));
            //var n = list.Insert("my", "from");
            //list.Insert("super", n);
            //Console.WriteLine();
            //list.Traverse(s => Console.Write($"{s} "));
            //Console.ReadKey();

            //Console.Title = "Custom Stack with List";
            //var stack = new CustomStackUsingList<string>();
            //stack.Push("Hello");
            //stack.Push("world");
            //stack.Push("from");
            //stack.Push("C#");
            //Console.WriteLine($"Stack count: {stack.Count}");
            //while (!stack.IsEmpty)
            //{
            //    var word = stack.Pop();
            //    Console.Write($"{word} ");
            //}
            //Console.WriteLine($"\r\nStack count: {stack.Count}");
            //Console.ReadKey();

            Console.Title = "Custom Queue with LinkedList";
            var queue = new CustomQueue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("world");
            queue.Enqueue("from");
            queue.Enqueue("my");
            queue.Enqueue("super");
            queue.Enqueue("queue");
            queue.Enqueue("class");
            while (queue.Count > 0)
            {
                Console.Write($"Before: {queue.Count} items, ");
                Console.Write($"Dequeued item: {queue.Dequeue()}, ");
                Console.WriteLine($"After: {queue.Count} items");
            }
            Console.ReadKey();
        }
    }
}
