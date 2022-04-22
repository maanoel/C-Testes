using System;
using System.Collections;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
     Queue queue = new Queue();
     
     queue.Enqueue("C#");
     queue.Enqueue("Java");
     queue.Enqueue("Python");
     
     Console.WriteLine(queue.Count);
     Console.WriteLine("The Bigginer is " + queue.Peek());
    }
  }
}