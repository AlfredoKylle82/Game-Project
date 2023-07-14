using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Weapons;
using Midterm_Project.Items;


namespace Midterm_project.Champions
{
    public class Character
    {
        
        private int hp;
        private int mana;
  
        
        private Weapon weapon;

 
        Dictionary<String, Ability> abilitiesMap = new Dictionary<String, Ability>();
        Dictionary<String, Item> itemsMap = new Dictionary<String, Item>();
        
        public Character(int hp, int mana)
        {
            this.hp = hp;
            this.mana = mana;
           
        }

        public void addAbility(Ability ability)
        {
            this.abilitiesMap[ability.getAbilityName()] = ability;
        }

        public Ability getAbility(String name)
        {
            return abilitiesMap[name];
        }

        public string[] getAbilityNames()
        {
            String[] myKeys = new String[abilitiesMap.Count];
            abilitiesMap.Keys.CopyTo(myKeys, 0);
            return myKeys;
        }

        public void addItem(Item item)
        {
            this.itemsMap[item.getitemName()] = item;
        }

        public Item getItem(String itemName)
        {
            return itemsMap[itemName];
        }
        public string[] getItemNames()
        {
            String[] myKeys = new String[itemsMap.Count];
            itemsMap.Keys.CopyTo(myKeys, 0);
            return myKeys;
        }
        public Weapon getWeapon()
        {
            return this.weapon;
        }

        public void setWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public int getHp()
        {
            return this.hp;
        }
        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public int getMana()
        {
            return this.mana;
        }

        public void setMana(int mana)
        {
            this.mana = mana;
        }

      
    }
}
