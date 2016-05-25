﻿using System;

namespace PatternAdapter
{
    public class MallardDuck : Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}