using Midterm_Project.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Project.Weapons
{
    class GuardianWeapon : Weapon
    {
        private int totalWeaponDamage;
        public GuardianWeapon(int weaponDamage, int weaponAmmo, string weaponName)
        {
            this.weaponDamage = weaponDamage;
            this.weaponAmmo = weaponAmmo;
            this.weaponName = weaponName;

        }

        
        public override void useWeapon(Player owner, Player opponent)
        {
            if (weaponAmmo > 0)
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 4);

                if (rand_num == 1)
                {
                    totalWeaponDamage = weaponDamage + 150;
                    Console.WriteLine("\nHEADSHOT! You dealt " + totalWeaponDamage + " To your opponent.\n");
                    
                }
                else
                {
                    totalWeaponDamage = weaponDamage;
                    Console.WriteLine("\nYou dealt " + totalWeaponDamage + " To your opponent.\n");
                }

                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - totalWeaponDamage);
                this.weaponAmmo = weaponAmmo - 30;


            }
            else
            {
                Console.WriteLine("\nYou don't have enough ammo\n");
            }
        }


    }
}
