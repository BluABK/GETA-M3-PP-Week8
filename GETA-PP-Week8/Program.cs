using System;
using System.Collections.Generic;

namespace GETA_PP_Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            int test1 = 5;
            int test2 = 5;

            int test3 = 0;
            Console.WriteLine($"test3 pre: {test3}");
            test3 = GetNewValue(test1);
            Console.WriteLine($"test3 post: {test3}");

            Console.WriteLine($"test2 pre: {test2}");
            ChangeValueByRef(test2);
            Console.WriteLine($"test2 post: {test2}");

            List<int> numbers = new() { 1, 1, 5, 6, 8, 1 };

            List<int> odds = numbers.FindAll(i => i % 2 == 1);
            List<int> evens = numbers.FindAll(i => i % 2 == 0);


            List<int> odds2 = new();
            List<int> evens2 = new();
            foreach(int i in numbers)
            {
                if (i % 2 == 0 )
                {
                    evens2.Add(i);
                } else
                {
                    odds2.Add(i);
                }
            }
            
            Console.WriteLine($"Odd number count: {odds.Count}");
            Console.WriteLine($"Even number count: {evens.Count}");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"Odd number count: {odds2.Count}");
            Console.WriteLine($"Even number count: {evens2.Count}");

        }

        public static void ChangeValueByRef(int val)
        {
            val *= 5;
        }

        public static int GetNewValue(int val)
        {
            return val * 5;
        }
    }
}
