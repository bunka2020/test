using System;
using System.Collections.Generic;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 1; i <= N; i += 2) {
                list.Add(i);
            }

            foreach (object vaule in list)
            {
                Console.WriteLine(vaule);
            }
        }
    }
}
