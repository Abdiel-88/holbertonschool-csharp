// 3-stack_push_pop.cs
using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in aStack
        Console.WriteLine($"Number of items: {aStack.Count}");
        
        // Print the item at the top of aStack without removing it
        if (aStack.Count > 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Print if aStack contains a given item search
        bool contains = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {contains}");

        // If aStack contains the given item search, remove all items up to and including search
        if (contains)
        {
            Stack<string> tempStack = new Stack<string>();
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
                tempStack.Push(item);
            }
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add a new given item newItem to aStack
        aStack.Push(newItem);

        return aStack;
    }
}
