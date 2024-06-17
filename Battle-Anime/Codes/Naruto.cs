using System;

namespace BattleGame
{
    class Naruto : Character
    {
        private string charName;
        private int attackPower;
        private int healPower;
        public int currentHP;

        public Naruto()
        {
            this.charName = "Naruto";
            this.attackPower = 15;
            this.healPower = 20;
            this.currentHP = maxHP;
        }

        public override string ToString()
        {
            return $"Character Name: {charName} \nTotal HP: {currentHP} \nAttack Power: {attackPower} \nHeal Powe: {healPower}";
        }
    }
}