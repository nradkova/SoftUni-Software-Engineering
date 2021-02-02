﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                   
                }
                if (input[i]==')')
                {
                    int endIndex = i;
                    int startIndex = stack.Pop();
                    string output = input.Substring(startIndex, endIndex - startIndex+1);
                    Console.WriteLine(output);
                }
            }
        
        }
    }
}
