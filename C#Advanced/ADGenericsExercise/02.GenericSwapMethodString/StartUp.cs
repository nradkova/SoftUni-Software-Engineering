﻿using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>();
                box.Value = int.Parse(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Box<string> box = new Box<string>();
            //    box.Value = Console.ReadLine();
            //    Console.WriteLine(box.ToString());
            //}
        }
    }
}
