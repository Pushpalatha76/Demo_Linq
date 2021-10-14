using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Demo_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Implementation in csharp");
            int[] scores = new int[] { 20, 25, 30, 35, 40, 45, 50 };

            IEnumerable<int> Scorequery =
                from score in scores
                where score > 35
                select score;
            foreach(var item in Scorequery)
            {
                Console.WriteLine("value:{0}\n", item);
            }

        }
    }
}
