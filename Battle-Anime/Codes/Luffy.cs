using System;

namespace BattleGame
{
    class Luffy : Character
    {
        private string charName;
        private int attackPower;
        private int healPower;
        public int currentHP;

        public Luffy()
        {
            this.charName = "Luffy";
            this.attackPower = 15;
            this.healPower = 15;
            this.currentHP = maxHP;
        }

        public override string ToString()
        {
            return $"Character Name: {charName} \nTotal HP: {currentHP} \nAttack Power: {attackPower} \nHeal Powe: {healPower}";
        }
    }
}