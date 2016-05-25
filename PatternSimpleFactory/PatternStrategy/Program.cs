﻿using System;
using PatternStrategy.GameAction;
using PatternStrategy.SimUDuck;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game");

            Character character = new King();
            character.SetWeapon(new Knife());
            character.Fight();
            character.SetWeapon(new BowAndArrow());
            character.Fight();

            Console.WriteLine("\nDuck");

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();
        }
    }
}