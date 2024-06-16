using System;

namespace BattleGame
{
    class Naruto : Character
    {
        private string charName;
        private int attackPower;
        private int healPower;
        private Random power;

        public Naruto(int attackPower, int healPower)
        {
            this.charName = "Naruto";
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.power = new Random();
        }

        
    }
}