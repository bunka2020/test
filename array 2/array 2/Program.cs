﻿using System;
using System.Collections.Generic; 
namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <=N; i *= 2)
            {
                numbers.Add(i);
            }
            foreach (int vaule in numbers)
            {
                Console.WriteLine(vaule);
            }
        }
    }
}
