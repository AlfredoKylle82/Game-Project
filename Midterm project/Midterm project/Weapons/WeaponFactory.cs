using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Project.Weapons
{
    class WeaponFactory
    {


        public static VandalWeapon createVandal(int weaponDamage, int weaponAmmo, string weaponName)
        {
            VandalWeapon obj = new VandalWeapon(weaponDamage, weaponAmmo, weaponName);
            return obj;
        }
        public static OperatorWeapon createOperator(int weaponDamage, int weaponAmmo, string weaponName)
        {
            OperatorWeapon obj = new OperatorWeapon(weaponDamage, weaponAmmo, weaponName);
            return obj;
        }
        public static GuardianWeapon createGuardian(int weaponDamage, int weaponAmmo, string weaponName)
        {
            GuardianWeapon obj = new GuardianWeapon(weaponDamage, weaponAmmo, weaponName);
            return obj;
        }


    }
}
