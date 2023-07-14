using System;
using System.Collections.Generic;
using System.Text;
using Midterm_project.Champions;
using Midterm_Project.Items;


namespace Midterm_Project.Characters
{
    public class Player
    {
        string playerName;
        Character character;
        Item item;

        public void setPlayerName(String name)
        {
            this.playerName = name;
        }

        public String getPlayerName()
        {
            return playerName;
        }

        public void setCharacter(Character character)
        {
            this.character = character;
        }

        public Character getCharacter()
        {
            return this.character;
        }
        
        public void setItem(Item item)
        {
            this.item = item;
        }

        public Item getItem()
        {
            return this.item;
        }


    }
}
