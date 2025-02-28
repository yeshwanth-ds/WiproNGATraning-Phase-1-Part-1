using System;
using System.Collections.Generic; // Required for Queue<T>

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a Queue of integers
        Queue<int> queue = new Queue<int>();

        // Enqueue (Add elements to the queue)
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        // Displaying elements in the queue
        Console.WriteLine("Elements in the queue:");
        foreach (int num in queue)
        {
            Console.WriteLine(num);
        }

        // Dequeue (Remove element from the front)
        int removedItem = queue.Dequeue();
        Console.WriteLine($"\nDequeued item: {removedItem}");

        // Peek (Check the front element without removing it)
        int frontItem = queue.Peek();
        Console.WriteLine($"Front item after dequeue: {frontItem}");

        // Checking if an element exists
        Console.WriteLine(queue.Contains(30) ? "30 is in the queue." : "30 is not in the queue.");

        // Getting count of elements
        Console.WriteLine($"Number of elements in queue: {queue.Count}");

        // Clearing the queue
        queue.Clear();
        Console.WriteLine($"Queue cleared. Current count: {queue.Count}");
    }
}
