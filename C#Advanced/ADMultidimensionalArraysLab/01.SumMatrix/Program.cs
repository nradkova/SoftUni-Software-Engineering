﻿using System;
using System.Linq;

namespace _01.SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(", ").
                Select(int.Parse).ToArray();
            int[,] matrix = new int[elements[0], elements[1]];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[]numbers = Console.ReadLine().Split(", ").
                Select(int.Parse).ToArray();
                for (int col  = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);

        }
    }
}
