﻿using System;

namespace _18.StopNumber
{
    public class StopNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
