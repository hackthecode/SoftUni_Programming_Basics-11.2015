﻿using System;
using System.Numerics;

namespace _07.CalculateCombinatoric
{
    class CalculateCombinatoric
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nomrator = 1;
            BigInteger denominator = 1;
            for (int i = n; i > k; i--)
            {
                nomrator *= i;
            }
            for (int j = 1; j <= n - k; j++)
            {
                denominator *= j;
            }
            Console.WriteLine(nomrator / denominator);
        }
    }
}
