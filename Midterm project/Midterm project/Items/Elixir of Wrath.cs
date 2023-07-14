using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;
using Midterm_project.Champions;

namespace Midterm_Project.Items
{
    class Elixir_of_Wrath : Item
    {
        public Elixir_of_Wrath(int heal, int manaRegen, string itemName, int adIncrease, int limit)
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

                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - adIncrease);
                Console.WriteLine("\nThe Item has dealt " + adIncrease + " to the opponent\n");

                limit--;
            }
            else
            {
                Console.WriteLine("\nYou have used all your items\n");
            }
        }
    }
}
