using System;

namespace BattleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Naruto naruto = new Naruto();
            Goku goku = new Goku();
            Luffy luffy = new Luffy();

            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("Choose Your Character below:");

            Console.WriteLine("1. Naruto \n2. Goku \n3. Luffy \n");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n" + naruto.ToString() + "\n");
                    naruto.Start();
                    break;
                case 2:
                    Console.WriteLine("\n" + goku.ToString() + "\n");
                    goku.Start();
                    break;
                case 3:
                    Console.WriteLine("\n" + luffy.ToString() + "\n");
                    luffy.Start();
                    break;
            }
        }
    }
}