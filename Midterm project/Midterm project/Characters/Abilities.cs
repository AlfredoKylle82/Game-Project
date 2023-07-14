using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;

namespace Midterm_project.Champions
{
    public class Ability
    {
        protected int attackDamage;
        protected int manaConsumption;
        protected string AbilityName;
        protected int followUpDamage = 0;
        protected int totalDamage;

        public Ability()
        {

        }

        public Ability(int attackDamage, int manaConsumption, string AbilityName)
        {
            this.attackDamage = attackDamage;
            this.manaConsumption = manaConsumption;
            this.AbilityName = AbilityName;
        }

        public string getAbilityName()
        {
            return AbilityName;
        }

        public void setAbilityName(string AbilityName)
        {
            this.AbilityName = AbilityName;
        }
        public int getAttackDamage()
        {
            return attackDamage;
        }

        public void setAttackDamage(int attackDamage)
        {
            this.attackDamage = attackDamage;
        }

        public int getAttackMana()
        {
            return manaConsumption;
        }

        public void setManaConsumption(int manaConsumption)
        {
            this.manaConsumption = manaConsumption;
        }

        public int getFollowUpDamage()
        {
            return followUpDamage;
        }

        public void setFollowUpDamage(int followUpDamage)
        {
            this.followUpDamage = followUpDamage;
        }

        public virtual void useAbility(Player owner, Player opponent)
        {
            if (owner.getCharacter().getMana() > 0)
            {
                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - attackDamage);
                owner.getCharacter().setMana(owner.getCharacter().getMana() - manaConsumption);
                Console.WriteLine("\nDamage dealt to the opponent: " + attackDamage);
            }
            else
            {
                Console.WriteLine("\nYou don't have enough mana\n");
            }
         

        }

        public virtual void useAbility(Player owner, Player opponent, Ability previousAbility)
        {
            if (owner.getCharacter().getMana() > 0)
            {
                Console.WriteLine("\nYour ability have dealt " + attackDamage + " to the enemy \n");

                if(previousAbility != null)
                {
                    totalDamage = attackDamage + previousAbility.getFollowUpDamage();
                    if (previousAbility.getFollowUpDamage() > 0)
                    {
                        Console.WriteLine("\n" + previousAbility.getAbilityName() + " dealt an additional damage of " + previousAbility.getFollowUpDamage() + "\n");
                    }
                } else
                {
                    totalDamage = attackDamage;
                }
                
               
                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - totalDamage);
                owner.getCharacter().setMana(owner.getCharacter().getMana() - manaConsumption);


            }
            else
            {
                Console.WriteLine("\nYou don't have enough mana\n");
            }
        }
    }
}
