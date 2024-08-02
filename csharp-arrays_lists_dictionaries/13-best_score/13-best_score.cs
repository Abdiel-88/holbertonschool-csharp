using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string bestKey = null;
        int bestValue = -1;

        foreach (var item in myList)
        {
            if (item.Value > bestValue)
            {
                bestValue = item.Value;
                bestKey = item.Key;
            }
        }

        return bestKey;
    }
}
