using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;

namespace Midterm_Project.Characters.Lucian_Abilities
{
    class TheCullingAbility : Ability
    {
        public TheCullingAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
        }



    }
}
