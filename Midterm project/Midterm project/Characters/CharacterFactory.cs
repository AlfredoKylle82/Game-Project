using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_project.Champions
{
    public class CharacterFactory
    {
        public static Character createCharacter(int hp, int mana)
        {
            Character obj = new Character(hp, mana);
            return obj;
        }
    }

 }
        

            

 









