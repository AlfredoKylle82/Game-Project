using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;

namespace Midterm_project.Champions
{
    class CurtainCallAbility : Ability
    {
        //4 turn shots mechanic
      

      

        public CurtainCallAbility(int attackDamage, int manaConsumption, string AbilityName)
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

