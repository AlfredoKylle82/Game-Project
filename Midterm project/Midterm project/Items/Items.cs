using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;

namespace Midterm_Project.Items
{
    public class Item
    {


        protected int heal;
        protected int manaRegen;
        protected string itemName;
        protected int lifesteal;
        protected int adIncrease;
        protected int limit;

        public Item()
        {

        }

        public Item(int heal, int manaRegen, string itemName, int adIncrease, int limit)
        {
            this.heal = heal;
            this.manaRegen = manaRegen;
            this.itemName = itemName;
            this.adIncrease = adIncrease;
            this.limit = limit;
        }

        public string getitemName()
        {
            return itemName;
        }
        public void setitemName(string itemName)
        {
            this.itemName = itemName;
        }
        public int getheal()
        {
            return heal;
        }
        public void setheal(int heal)
        {
            this.heal = heal;
        }
        public int getmanaRegen()
        {
            return manaRegen;
        }
        public void setmanaRegen(int manaRegen)
        {
            this.manaRegen = manaRegen;
        }
       
        public int getadIncrease()
        {
            return adIncrease;
        }
        public void setadIncrease(int adIncrease)
        {
            this.adIncrease = adIncrease;
        }

        public int getLimit()
        {
            return limit;
        }
        public void setLimit(int limit)
        {
            this.limit = limit ;
        }

        public virtual void useItem(Player owner, Player opponent)
        {
           if(limit > 0)
            {
                owner.getCharacter().setHp(owner.getCharacter().getHp() + heal);
                owner.getCharacter().setMana(owner.getCharacter().getMana() + manaRegen);
                Console.WriteLine("You gained " + heal + " HP and " + manaRegen + "Mana");
            }
            else
            {
                Console.WriteLine("You have used all your items");
            }
        }

    }
}
