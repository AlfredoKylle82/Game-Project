using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Project.Items
{
    class ItemFactory
    {
        public static Corrupting_Potion createCorruptingPotionItem(int heal, int manaRegen, string itemName, int adIncrease, int limit)
        {
            Corrupting_Potion obj = new Corrupting_Potion(heal, manaRegen, itemName, adIncrease, limit);

            return obj;


        }
        public static Elixir_of_Wrath createElixirOfWrathItem(int heal, int manaRegen, string itemName, int adIncrease, int limit)
        {
            Elixir_of_Wrath obj = new Elixir_of_Wrath(heal, manaRegen, itemName, adIncrease, limit);

            return obj;


        }
    }
}
