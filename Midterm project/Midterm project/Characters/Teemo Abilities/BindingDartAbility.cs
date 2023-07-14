using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;

namespace Midterm_Project.Characters.Teemo_Abilities
{
    public class BlindingDartAbility : Ability
    {
        public BlindingDartAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
            Console.WriteLine("attackDamage = " + this.attackDamage);
        }

    }
}
