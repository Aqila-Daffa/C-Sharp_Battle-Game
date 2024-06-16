using System;

namespace BattleGame
{
    abstract class Character
    {
        private int maxHP = 100;
        private int currentHP;
        private Random power = new Random();

        public void Start()
        {
            Console.WriteLine("Let's start the battle!");
        }

        public void Attack(Naruto naruto)
        {
            double crit = power.NextDouble();
            crit = crit / 2 + 0.75f;
            int damage = (int)(crit * damage);
            Attacked(damage);
            Console.WriteLine($"{naruto} attacks with {damage} total damage!");
        }

        public void Attacked(int damage)
        {
            maxHP -= damage;
            currentHP = maxHP;

            if (currentHP < 0)
                Console.WriteLine("Naruto is defeated!");
        }
    }
}