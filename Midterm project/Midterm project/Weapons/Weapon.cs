using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters;

namespace Midterm_Project.Weapons
{
    public class Weapon
    {
        protected int weaponDamage;
        protected int weaponAmmo;
        protected string weaponName;

        public Weapon(int weaponDamage, int weaponAmmo, string weaponName)
        {
            this.weaponDamage = weaponDamage;
            this.weaponAmmo = weaponAmmo;
            this.weaponName = weaponName;

        }

        public int getWeaponAmmo()
        {
            return weaponAmmo;
        }
        public void setWeaponAmmo(int weaponAmmo)
        {
           this.weaponAmmo = weaponAmmo;
        }

        public Weapon()
        {

        }



        public virtual void useWeapon(Player owner, Player opponent)
        {
            if (weaponAmmo > 0)
            {
                opponent.getCharacter().setHp(opponent.getCharacter().getHp() - weaponDamage);

                this.weaponAmmo = weaponAmmo - 15;
            } else
            {
                Console.WriteLine("You don't have enough ammo");
            }
        }
    }
}
