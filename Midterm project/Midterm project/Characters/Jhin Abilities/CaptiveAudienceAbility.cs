using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;
using Midterm_project.Champions;

namespace Midterm_project.Champions
{
     class CaptiveAudienceAbility : Ability
    {
        //Turn-activated trap Mechanic

        private int totalDamage = 75;
        public CaptiveAudienceAbility(int attackDamage, int manaConsumption, string AbilityName)
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