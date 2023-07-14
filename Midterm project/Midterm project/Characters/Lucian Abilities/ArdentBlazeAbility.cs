using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;
using Midterm_Project.Characters;

namespace Midterm_Project.Characters.Lucian_Abilities

{
    class ArdentBlazeAbility : Ability
    {
        //Turn-activated bonus damage mechanic

        
       

       

        public ArdentBlazeAbility(int attackDamage, int manaConsumption, string AbilityName)
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
