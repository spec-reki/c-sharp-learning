﻿using System;

namespace Episode
{
    class Program
    {
        static void Main(String[] args)
        {




            // Wait before closing
            Console.ReadKey();
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name =  "M-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm" + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, and I'm an alien.");
        }
    }
}