﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LetterCombination
{
    class LetterCombination
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char left = char.Parse(Console.ReadLine());

            int combination = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i == left || j == left || k == left)
                        {
                            continue;                           
                        }
                        combination++;
                        Console.Write("{0}{1}{2} ", i, j, k);   
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}
