using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Events;

namespace Weapons
{
    public class Weapons
    {
        public static void Main()
        {

//WEAPONS

//Berreta M9
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "Berreta M9",
                    NameToOrderByOverride = "+APL[Heavy]",
                    DescriptionOverride = "The Beretta M9 is a self-loading pistol chambered for 9 x 19 mm.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/berreta_m9.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/berreta_m9.png", 0.95f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.1f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "Pistol";
                        customCartridge.Damage *= 0.4f;
                        customCartridge.StartSpeed *= 5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1f;
                        customCartridge.Recoil *= 0.2f;
                        customCartridge.ImpactForce *= 1f; 
			            firearm.Cartridge = customCartridge;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;
  
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 1f;
                        firearm.Automatic = true;
                        firearm.InitialInaccuracy = 0.2f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/berreta_m9.mp3"),
						};
				    }
				}
            );
           
           //MP-5

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "MP-5",
                    NameToOrderByOverride = "+APL[Light]",
                    DescriptionOverride = "family of submachine guns developed by the German small arms manufacturer Heckler & Koch (HK) in the 1960s based on the HK G3.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/MP-5.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/MP-5.png", 0.9f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.15f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "MP-5";
                        customCartridge.Damage *= 1f;
                        customCartridge.StartSpeed *= 3.0f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.5f;
                        customCartridge.Recoil *= 0.3f;
                        customCartridge.ImpactForce *= 0.3f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 0.08f;
                        firearm.Automatic = true;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;
                        firearm.InitialInaccuracy = 0.1f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/MP-5.mp3"),
                        };
				    }
				}
            );

            //AKC-74Y

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "AKC-74Y",
                    NameToOrderByOverride = "+APL[Light]",
                    DescriptionOverride = "a shortened version of the AKS74 assault rifle, was developed in the late 1970s and early 1980s to arm the crews of combat vehicles, aircraft, gun crews, and paratroopers.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/AKC-74Y.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/AKC-74Y.png", 0.9f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.15f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "AKC-74Y";
                        customCartridge.Damage *= 2f;
                        customCartridge.StartSpeed *= 3.0f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.5f;
                        customCartridge.Recoil *= 0.5f;
                        customCartridge.ImpactForce *= 0.5f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 0.08f;
                        firearm.Automatic = true;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;
                        firearm.InitialInaccuracy = 0.2f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/AKC-74Y.mp3"),
                        };
				    }
				}
            );

               //AKC-74Y

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "AKC-74Y Gold",
                    NameToOrderByOverride = "+APL[Light]",
                    DescriptionOverride = "a shortened version of the AKS74 assault rifle, was developed in the late 1970s and early 1980s to arm the crews of combat vehicles, aircraft, gun crews, and paratroopers.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/AKC-74Yg.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/AKC-74Yg.png", 0.9f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.15f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "AKC-74Y G";
                        customCartridge.Damage *= 2.5f;
                        customCartridge.StartSpeed *= 3.0f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.5f;
                        customCartridge.Recoil *= 0.3f;
                        customCartridge.ImpactForce *= 0.5f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 0.08f;
                        firearm.Automatic = true;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;
                        firearm.InitialInaccuracy = 0.2f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/AKC-74Y.mp3"),
                        };
				    }
				}
            );

            //Taurus Judge
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "Taurus Judge",
                    NameToOrderByOverride = "+APL[Shotgun]",
                    DescriptionOverride = "The Taurus Judge is a five shot revolver designed and produced by Taurus International, chambered for .410 bore shot shells and the .45 Colt cartridge.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/taurus_judge.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/Taurus_judge.png", 1f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.3f, 0.1f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "Taurus Judge";
                        customCartridge.Damage *= 2f;
                        customCartridge.StartSpeed *= 5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 5f;
                        customCartridge.Recoil *= 0.2f;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;

                        customCartridge.ImpactForce *= 1f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 3;
                        firearm.AutomaticFireInterval = 1f;
                        firearm.Automatic = false;
                        firearm.InitialInaccuracy = 0.3f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/taurus_judge.mp3"),
						};
				    }
				}
            );

             //Serbu Super Shorty
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "Serbu Super Shorty",
                    NameToOrderByOverride = "+APL[Shotgun]",
                    DescriptionOverride = "The Serbu Super-Shorty is a compact, stockless, pump-action AOW chambered in 12-gauge.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/serbu_super_shorty.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/serbu_super_shorty.png", 1f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.3f, 0.1f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "Serbu Super Shorty";
                        customCartridge.Damage *= 2f;
                        customCartridge.StartSpeed *= 5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 5f;
                        customCartridge.Recoil *= 0.2f;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;

                        customCartridge.ImpactForce *= 2f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 3;
                        firearm.AutomaticFireInterval = 1f;
                        firearm.Automatic = false;
                        firearm.InitialInaccuracy = 0.3f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/serbu_super_shorty.mp3"),
						};
				    }
				}
            );

            //BOSG
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "BOSG",
                    NameToOrderByOverride = "+APL[Shotgun]",
                    DescriptionOverride = "Break-through double-barreled shotgun with vertical barrels in a tactical configuration.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/bosg.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/bosg.png", 1f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.3f, 0.1f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "BOSG";
                        customCartridge.Damage *=4f;
                        customCartridge.StartSpeed *= 5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 5f;
                        customCartridge.Recoil *= 0.7f;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;

                        customCartridge.ImpactForce *= 1f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 1f;
                        firearm.Automatic = false;
                        firearm.InitialInaccuracy = 0.1f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/bosg.mp3"),
						};
				    }
				}
            );

            //Kar 98k
                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "Kar 98k",
                    NameToOrderByOverride = "+APL[Shotgun]",
                    DescriptionOverride = "a magazine rifle, officially adopted in 1935. It was the main and most massive small arms of the Wehrmacht.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/kar98k.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/kar98k.png", 1f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.3f, 0.1f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "Kar 98k";
                        customCartridge.Damage *=6f;
                        customCartridge.StartSpeed *= 5f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 5f;
                        customCartridge.Recoil *= 1f;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;

                        customCartridge.ImpactForce *= 2f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 1f;
                        firearm.Automatic = false;
                        firearm.InitialInaccuracy = 0.1f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/kar98k.mp3"),
						};
				    }
				}
            );

            //UZI

                ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Assault Rifle"),
                    NameOverride = "UZI",
                    NameToOrderByOverride = "+APL[Light]",
                    DescriptionOverride = "family of submachine guns developed by the German small arms manufacturer Heckler & Koch (HK) in the 1960s based on the HK G3.",
                    CategoryOverride = ModAPI.FindCategory("Firearms"),
                    ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/uzi.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/uzi.png", 0.9f);
                        Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.15f);

                        foreach (var c in Instance.GetComponents<Collider2D>())
                        {
                            GameObject.Destroy(c);
                        }
                        Instance.AddComponent<PolygonCollider2D>();        
                        Instance.FixColliders();
                        var firearm = Instance.GetComponent<FirearmBehaviour>();
			            Cartridge customCartridge = ModAPI.FindCartridge("50 AE");
                        customCartridge.name = "UZI";
                        customCartridge.Damage *= 1f;
                        customCartridge.StartSpeed *= 4.0f;
                        customCartridge.PenetrationRandomAngleMultiplier *= 1.5f;
                        customCartridge.Recoil *= 0.3f;
                        customCartridge.ImpactForce *= 0.3f;
			            firearm.Cartridge = customCartridge;    
                        firearm.BulletsPerShot = 1;
                        firearm.AutomaticFireInterval = 0.08f;
                        firearm.Automatic = true;
                        var phys = Instance.GetComponent<PhysicalBehaviour>();
                        phys.Properties = ModAPI.FindPhysicalProperties("Weapon");
                        phys.TrueInitialMass = 0.10f;
                        phys.InitialMass = 0.10f;
                        phys.rigidbody.mass = 0.10f;
                        firearm.InitialInaccuracy = 0.3f;
                        
			            firearm.ShotSounds = new AudioClip[]
						{
                           ModAPI.LoadSound("Sound/uzi.mp3"),
                        };
				    }
				}
            );

            //Katana
			ModAPI.Register(
                    new Modification()
                    {
                        OriginalItem = ModAPI.FindSpawnable("Knife"),
                        NameOverride = "Katana",
                        NameToOrderByOverride = "+APL[Katana]",
                        DescriptionOverride = " ",
                        CategoryOverride = ModAPI.FindCategory("Melee"),
                        ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/katana.png"),
                        AfterSpawn = (Instance) =>
                        {
                            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/katana.png", 1f);
                            foreach (var c in Instance.GetComponents<Collider2D>())
                            {
                                GameObject.Destroy(c);
                            }
                            Instance.AddComponent<PolygonCollider2D>();        
                        }
                    }
                );

            //big bundle of dynamite

            ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Dynamite"),
        NameOverride = "big bundle of dynamite",
        NameToOrderByOverride = "E",
         DescriptionOverride = "BOOOOOM",
        CategoryOverride = ModAPI.FindCategory("Explosives"),
        ThumbnailOverride = ModAPI.LoadSprite("Thumbnail/dynamite_bundle.png"),
        AfterSpawn = (Instance) =>
    {
        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Weapons/dynamite_bundle.png", 1f);
        ExplosiveBehaviour explbehaviour = Instance.GetComponent(typeof(ExplosiveBehaviour)) as ExplosiveBehaviour;
        explbehaviour.Range = 64f;
        explbehaviour.Delay = 0f;
        Instance.FixColliders();

      
                        }
                    }
                );

                //Instance.AddComponent<SvitAnim>();
        }
    }
    public class BurstFireAdapter : MonoBehaviour
    {
        public float Interval = 0.1f;
        public int BurstCount = 5;

        private bool busy = false;

        private CanShoot firearm;

        private void Awake()
        {
            firearm = GetComponent<CanShoot>();
        }

        private void Use()
        {
            StartCoroutine(Burst());
        }

        private System.Collections.IEnumerator Burst()
        {
            if (busy) yield break;
            busy = true;
            for (int i = 0; i < BurstCount - 1; i++)
            {
                yield return new WaitForSeconds(Interval);
                firearm.Shoot();
            }
            busy = false;
        }
    } 
}   