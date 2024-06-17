using System;

namespace BattleGame
{
    abstract class Character
    {
        public int maxHP = 100;

        public void Start()
        {
            Console.WriteLine("Let's start the battle!");
        }

        public abstract string ToString();
    }
}