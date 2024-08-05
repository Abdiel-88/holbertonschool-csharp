// 4-queue_enqueue_dequeue.cs
using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in aQueue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print the item at the top of aQueue without removing it
        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Add a new given item newItem to aQueue
        aQueue.Enqueue(newItem);

        // Print if aQueue contains a given item search
        bool contains = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {contains}");

        // If aQueue contains the given item search, remove all items up to and including search
        if (contains)
        {
            Queue<string> tempQueue = new Queue<string>();
            bool found = false;
            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                {
                    found = true;
                    break;
                }
                tempQueue.Enqueue(item);
            }
            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
            if (!found)
            {
                aQueue.Enqueue(search);
            }
        }

        return aQueue;
    }
}
