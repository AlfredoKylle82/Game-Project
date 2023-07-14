using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Characters.Lucian_Abilities;
using Midterm_Project.Characters.Teemo_Abilities;

namespace Midterm_project.Champions
{
    public class Ability_Factory
    {
        public static DancingGrenadeAbility createDancingGrenadeAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            DancingGrenadeAbility obj = new DancingGrenadeAbility(attackDamage, manaConsumption, AbilityName);

            return obj;


        }

        public static Ability createCaptiveAudienceAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            CaptiveAudienceAbility obj = new CaptiveAudienceAbility(attackDamage, manaConsumption, AbilityName);
            obj.setFollowUpDamage(35);
            return obj;


        }
        public static Ability createCurtainCallAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            CurtainCallAbility obj = new CurtainCallAbility(attackDamage, manaConsumption, AbilityName);
            
            return obj;


        }

        public static Ability createPiercingLightAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            PiercingLightAbility obj = new PiercingLightAbility(attackDamage, manaConsumption, AbilityName);
            
            return obj;


        }
        public static Ability createArdentBlazeAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            ArdentBlazeAbility obj = new ArdentBlazeAbility(attackDamage, manaConsumption, AbilityName);
            obj.setFollowUpDamage(25);
            
            return obj;


        }

        public static Ability createTheCullingAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            TheCullingAbility obj = new TheCullingAbility(attackDamage, manaConsumption, AbilityName);
            
            return obj;


        }
        public static Ability createBlindingDartAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            BlindingDartAbility obj = new BlindingDartAbility(attackDamage, manaConsumption, AbilityName);
            
            return obj; 


        }
        public static Ability createNoxiousTrapAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            NoxiousTrapAbility obj = new NoxiousTrapAbility(attackDamage, manaConsumption, AbilityName);
            obj.setFollowUpDamage(50);
            return obj;

        }
        public static Ability createToxicShotAbility(int attackDamage, int manaConsumption, string AbilityName)
        {
            ToxicShotAbility obj = new ToxicShotAbility(attackDamage, manaConsumption, AbilityName);
            obj.setFollowUpDamage(25);
            return obj;

        }

    }
}
