﻿

using ArenaHW.Heroes;
using ArenaHW.Weapons;
using ArenaHW;
using System;

namespace ArenaHW
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");

        }
        static void Main(string[] args)
        {
            /*
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };
            */
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Berserker("Berserker", 10, 10, new CeremonialDagger("CDagger")),
                HeroB = new Knight("Knight", 11, 12, new Swordbreaker("Sword Breker")),
                NotificationsCallBack = ConsoleNotification
            };



            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}