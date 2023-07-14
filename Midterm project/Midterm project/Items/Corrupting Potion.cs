using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;


namespace Midterm_Project.Items
{
    class Corrupting_Potion : Item
    {
        public Corrupting_Potion(int heal, int manaRegen, string itemName, int adIncrease, int limit)
        {
            this.heal = heal;
            this.manaRegen = manaRegen;
            this.itemName = itemName;
            this.adIncrease = adIncrease;
            this.limit = limit;
        }
        public override void useItem(Player owner, Player opponent)
        {
            if (limit > 0)
            {
                owner.getCharacter().setHp(owner.getCharacter().getHp() + heal);
                owner.getCharacter().setMana(owner.getCharacter().getMana() + manaRegen);
                Console.WriteLine("\nYou gained " + heal + " HP and " + manaRegen + "Mana\n");
                limit--;
            }
            else
            {
                Console.WriteLine("\nYou have used all your items\n");
            }
        }
    }
}
