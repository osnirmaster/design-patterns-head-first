﻿using System;

namespace PatternTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea myTea = new Tea();
            myTea.PrepareRecipe();

            Console.ReadKey();
        }
    }
}