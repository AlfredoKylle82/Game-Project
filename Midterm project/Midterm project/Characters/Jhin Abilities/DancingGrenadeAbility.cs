using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;

namespace Midterm_project.Champions
{
    public class DancingGrenadeAbility : Ability

    {
        private int TotalDamage;

     
        public DancingGrenadeAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
        }

        public int getTotalDamage()
        {
            return this.TotalDamage;
        }


        public override void useAbility(Player owner, Player opponent)
        {
            if (owner.getCharacter().getMana() > 0)
            {

                Random rd = new Random();
                int rand_num = rd.Next(1, 6);


                if (rand_num == 2)
                {
                    Console.WriteLine("The ability hit twice!");
                    TotalDamage = attackDamage + 25;
                    
                }

                if (rand_num == 4)
                {
                    Console.WriteLine("The ability hit three times!");
                    TotalDamage = attackDamage + 45;
                }

                if (rand_num == 6)
                {
                    Console.WriteLine("The ability hit four times!");
                    TotalDamage = attackDamage + 65;
                }
                else
                {
                    Console.WriteLine("The ability hit only once!");
                }

                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - TotalDamage);
                owner.getCharacter().setMana(owner.getCharacter().getMana() - manaConsumption);
            }
            else
            {
                Console.WriteLine("You don't have enough mana");
            }
        }
    }
}