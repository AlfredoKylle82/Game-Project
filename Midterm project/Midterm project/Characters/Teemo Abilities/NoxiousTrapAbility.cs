using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;

namespace Midterm_Project.Characters.Teemo_Abilities
{
    public class NoxiousTrapAbility : Ability
    {
        //Turn-activated trap Mechanic

        public NoxiousTrapAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
        }

       

        public override void useAbility(Player owner, Player opponent)
        {
            if (owner.getCharacter().getMana() > 0)
            {
                base.useAbility(owner, opponent, null);
            }
            else
            {
                Console.WriteLine("You don't have enough mana");
            }
        }
    }
}
