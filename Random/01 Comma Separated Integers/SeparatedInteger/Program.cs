using System;
using System.Collections.Generic;

namespace SeparatedInteger
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new int[] { 12, 13, 14, 15, 16, 17, 18, 7, 96 };
            var newList = new List<int>();

            var data = "";

            for (var i = 0; i < a.Length; i++)
            {
                newList.Add(a[i]);

                //Solution 1
                if (newList.Count == 2 || i == (a.Length - 1))
                {
                    Console.WriteLine(string.Join(",", newList));
                    newList.Clear();
                }

                //Solution 2
                if (newList.Count == 2 || i == (a.Length - 1))
                {
                    data = data + String.Join(",", newList) + "\n";
                    newList.Clear();
                }
            }
            Console.WriteLine(data);
        }
    }
}
