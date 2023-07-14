using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;


namespace Midterm_Project.Weapons
{
    public class VandalWeapon : Weapon
    {
        private int totalWeaponDamage;
        public VandalWeapon(int weaponDamage, int weaponAmmo, string weaponName)
        {
            this.weaponDamage = weaponDamage;
            this.weaponAmmo = weaponAmmo;
            this.weaponName = weaponName;
        }
       
        public override void useWeapon(Player owner, Player opponent)
        {
            if (weaponAmmo > 0)
            {

                //Headshot Mechanic
                Random rd = new Random();
                int rand_num = rd.Next(1, 3);
                

                if (rand_num == 1)
                {
                    

                    totalWeaponDamage = weaponDamage + 150;
                    Console.WriteLine("\nHEADSHOT! You dealt " + totalWeaponDamage + " To your opponent.\n");
                }
                else
                {
                    Console.WriteLine(weaponDamage);

                    totalWeaponDamage = weaponDamage;
                    Console.WriteLine("\nYou dealt " + totalWeaponDamage + " To your opponent.\n");
                }
              
                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - totalWeaponDamage);
                this.weaponAmmo = weaponAmmo - 15;
                
            }
            else
            {
                Console.WriteLine("\nYou don't have enough ammo\n");
            }
        }

    }
}
