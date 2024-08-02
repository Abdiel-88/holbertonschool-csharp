using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Get the keys and sort them
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();
        
        // Print each key-value pair in sorted order
        foreach (string key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
