﻿using System;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var min = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine(min);
    }
}