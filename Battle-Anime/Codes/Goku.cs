using System;

namespace BattleGame
{
    class Goku : Character
    {
        private string charName;
        private int attackPower;
        private int healPower;
        public int currentHP;

        public Goku()
        {
            this.charName = "Goku";
            this.attackPower = 20;
            this.healPower = 15;
            this.currentHP = maxHP;
        }

        public override string ToString()
        {
            return $"Character Name: {charName} \nTotal HP: {currentHP} \nAttack Power: {attackPower} \nHeal Powe: {healPower}";
        }
    }
}