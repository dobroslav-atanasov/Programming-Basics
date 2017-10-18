﻿using System;

namespace _14.PartionWithoutResidue
{
    public class PartionWithoutResidue
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:F2}%", (p1 / n * 100));
            Console.WriteLine("{0:F2}%", (p2 / n * 100));
            Console.WriteLine("{0:F2}%", (p3 / n * 100));
        }
    }
}
