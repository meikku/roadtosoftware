﻿using System;
using System.Collections.Generic;

namespace exercise_77
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

            // Remember, this is how you print all the items in a list
            strings.ForEach(Console.WriteLine);

            RemoveLast(strings);
            RemoveLast(strings);

            strings.ForEach(Console.WriteLine);
            // You can try your method here if you want
        }
        public static void RemoveLast(List<string> strings)
        {
            int last = (strings.Count - 1);
            strings.RemoveAt(last);

        }

    }
}


