﻿using System;

namespace Program14{
    class Program    {
        static void Main(string[] args){

            Console.WriteLine("Put here some crazy number bro:");

            int count = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ReadKey();

        }            
    }
}