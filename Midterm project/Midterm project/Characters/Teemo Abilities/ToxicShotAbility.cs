using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;

namespace Midterm_Project.Characters.Teemo_Abilities
{
    class ToxicShotAbility : Ability
    {
         //Turn-activated bonus damage mechanic

        private int turnCounter = 2;

        public void decreaseTurnCounter()
        {
            turnCounter--;
        }



        public void setTurnCounter(int value)
        {
            this.turnCounter = value;
        }

        public void getTurnCounter(int value)
        {
            this.turnCounter = value;
        }

        public ToxicShotAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
        }

  
        public override void useAbility(Player owner, Player opponent)
        {
            base.useAbility(owner, opponent, null);

        }

    }
}
