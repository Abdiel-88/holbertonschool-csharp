﻿using System;

namespace Text
{
    /// <summary>
    /// method that returns the index
    /// of the first non-repeating character of a string.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns: index of first non-repeating character
        /// or -1 if there is no non-repeating character.
        /// </summary>
        public static int UniqueChar(string s)
        {
            string dot = ".";
            char hold;
            string used = "";
            for (int i = 0; i < s.Length; i++)
            {
                hold = s[i];
                s = dot + s.Remove(i, 1);
                if (!s.Contains(Char.ToString(hold)) && !used.Contains(Char.ToString(hold)))
                {
                    return i;
                }
                used += hold;
            }
            return -1;
        }
    }
}