using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;



namespace MoreExplosives
{
    public class Mod : MonoBehaviour
    {
        public static void Main()
        {

            //Hello Dataminer! Feel free to use some of this code for your own project if you want! If you have any questions feel free to contact me on Discord: Crafter215#0001
            // (The code isn't the best as I'm not that advanced in c# yet, thanks for reading this!)

            ModAPI.Register(
                     new Modification()
                     {
                         OriginalItem = ModAPI.FindSpawnable("Red Barrel"),
                         NameOverride = "Molotov Cocktail",
                         NameToOrderByOverride = "A",
                         DescriptionOverride = "A cocktail that when it explodes causes objects to light on fire!",
                         CategoryOverride = ModAPI.FindCategory("Explosives"),
                         ThumbnailOverride = ModAPI.LoadSprite("molotovthumb.png"),
                         AfterSpawn = (Instance) =>
                         {
                             Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Molotov.png", 0.2f);


                             Instance.GetComponent<ExplosiveBehaviour>().Range = 10f;
                             Instance.GetComponent<ExplosiveBehaviour>().ImpactForceThreshold = 0.15f;
                             Instance.GetComponent<ExplosiveBehaviour>().ExplodeBurnProgressThreshold = 10f;
                             Instance.GetComponent<ExplosiveBehaviour>().ShockwaveStrength = 0f;
                             Instance.GetComponent<ExplosiveBehaviour>().FragmentForce = 0f;
                             Instance.GetComponent<ExplosiveBehaviour>().BurnPower = 1f;
                             Instance.GetComponent<ExplosiveBehaviour>().DismemberChance = 0;
                             Instance.GetComponent<ExplosiveBehaviour>().BurnPower = 1f;
                             Instance.transform.localScale *= 0.15f;
                             //^ This right here exists because I messed up the sprite size, meaning if you copy and paste it, it will be pretty small! Will fix in an future update though!
                             Instance.FixColliders();
                         }




                     }
                 );



            ModAPI.Register(
                       new Modification()
                       {
                           OriginalItem = ModAPI.FindSpawnable("Rod"),
                           NameOverride = "Energy Rod",
                           NameToOrderByOverride = "Z",
                           DescriptionOverride = "An Energy Rod!",
                           CategoryOverride = ModAPI.FindCategory("Explosives"),

                           AfterSpawn = (Instance) =>
                           {

                               Instance.AddComponent<Charge>();

                           }

                       }
                   );

            ModAPI.Register(
         new Modification()
         {
             OriginalItem = ModAPI.FindSpawnable("Red Barrel"),
             NameOverride = "Impact Grenade",
             NameToOrderByOverride = "B",
             DescriptionOverride = "A grenade that can explodes if it hits something!",
             CategoryOverride = ModAPI.FindCategory("Explosives"),
             ThumbnailOverride = ModAPI.LoadSprite("impactgrenade.png"),
             AfterSpawn = (Instance) =>
             {
                 Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("impactgrenade.png", 1f);


                 Instance.GetComponent<ExplosiveBehaviour>().Range = 1f;
                 Instance.GetComponent<ExplosiveBehaviour>().ExplodeBurnProgressThreshold = 2f;
                 Instance.GetComponent<ExplosiveBehaviour>().ImpactForceThreshold = 5f;
                 Instance.GetComponent<ExplosiveBehaviour>().BurnPower = 0f;
                 Instance.GetComponent<ExplosiveBehaviour>().ShockwaveStrength = 1f;
                 Instance.GetComponent<ExplosiveBehaviour>().DismemberChance = 0.1f;
                 Instance.FixColliders();
             }




         }
     );

 
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Red Barrel"),
                NameOverride = "Gunpowder Box",
                NameToOrderByOverride = "D",
                DescriptionOverride = "A small box of gunpowder which when shot explodes!",

                CategoryOverride = ModAPI.FindCategory("Explosives"),
                ThumbnailOverride = ModAPI.LoadSprite("gunpowder.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("gunpowder.png", 1f);
                    ExplosiveBehaviour explbehaviour = Instance.GetComponent(typeof(ExplosiveBehaviour)) as ExplosiveBehaviour;
                    explbehaviour.Range = 15f;
                    explbehaviour.ShockwaveStrength = 1f;
                    explbehaviour.BurnPower = 0f;
                    Instance.transform.localScale *= 0.1f;
                    //^ This right here exists because I messed up the sprite size, meaning if you copy and paste it, it will be pretty small! Will fix in an future update though!
                    Instance.FixColliders();
     
                 
                }




            }
        ) ;


    ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Dynamite"),
        NameOverride = "Plastic Explosive",
        NameToOrderByOverride = "E",
         DescriptionOverride = "An Explosive that explodes after a short while and sticks to any surface upon activation!",
        CategoryOverride = ModAPI.FindCategory("Explosives"),
        ThumbnailOverride = ModAPI.LoadSprite("plasticexplosive.png"),
        AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("plasticexplosive.png", 1f);
        ExplosiveBehaviour explbehaviour = Instance.GetComponent(typeof(ExplosiveBehaviour)) as ExplosiveBehaviour;
        explbehaviour.Range = 30f;
        explbehaviour.Delay = 5f;
        Instance.FixColliders();

        Instance.AddComponent<StickyBehaviour>();


    }




}
);

    ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Handgrenade"),
        NameOverride = "Pressure Grenade",
        NameToOrderByOverride = "F",
         DescriptionOverride = "An Explosive that has a great pressure blast!",
        CategoryOverride = ModAPI.FindCategory("Explosives"),
        ThumbnailOverride = ModAPI.LoadSprite("pressuregrenade.png"),
        AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("pressuregrenade.png", 1f);
        ExplosiveBehaviour explbehaviour = Instance.GetComponent(typeof(ExplosiveBehaviour)) as ExplosiveBehaviour;
        explbehaviour.Range = 4f;
        Instance.GetComponent<ExplosiveBehaviour>().DismemberChance = 0;
        Instance.GetComponent<ExplosiveBehaviour>().ShockwaveStrength = 20000f;
        explbehaviour.Delay = 3f;
        Instance.FixColliders();
        Instance.GetComponent<ExplosiveBehaviour>().FragmentForce = 6f;



    }




}
);

    ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("General Purpose Bomb"),
        NameOverride = "Napalm Bomb",
        NameToOrderByOverride = "G",
         DescriptionOverride = "An Explosive that on impact, will do a lot of burning damage in a larger radius than the Molotov Cocktail!",
        CategoryOverride = ModAPI.FindCategory("Explosives"),
        ThumbnailOverride = ModAPI.LoadSprite("napalmthumb.png"),
        AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("napalmbomb.png", 1f);
        Instance.GetComponent<ExplosiveBehaviour>().Range = 25f;
        Instance.GetComponent<ExplosiveBehaviour>().ImpactForceThreshold = 15f;
        Instance.GetComponent<ExplosiveBehaviour>().ExplodeBurnProgressThreshold = 15f;
        Instance.GetComponent<ExplosiveBehaviour>().ShockwaveStrength = 5f;
        Instance.GetComponent<ExplosiveBehaviour>().FragmentForce = 0f;
        Instance.GetComponent<ExplosiveBehaviour>().BurnPower = 1f;
        Instance.GetComponent<ExplosiveBehaviour>().DismemberChance = 0;
        Instance.GetComponent<ExplosiveBehaviour>().BurnPower = 1f;
        Instance.transform.localScale *= 1.5f;
        Instance.FixColliders();

      


    }




}
);
        }

    }

}