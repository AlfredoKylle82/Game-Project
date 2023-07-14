using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;

namespace Midterm_Project.Characters.Lucian_Abilities
{
    class PiercingLightAbility : Ability
    {
        public PiercingLightAbility(int attackDamage, int manaConsumption, string AbilityName)
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
