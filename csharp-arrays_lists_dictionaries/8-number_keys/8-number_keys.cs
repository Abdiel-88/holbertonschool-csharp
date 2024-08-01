using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyCount = 0;

        // Iterate through the dictionary's keys to count them
        foreach (var key in myDict.Keys)
        {
            keyCount++;
        }

        return keyCount;
    }
}
