using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys.Enemies;

namespace CSCD454_FinalProject.Entitys
{
    class MonsterFactory
    {
        public Monster createMonster(String name){

            switch (name.ToLower())
            {
                case "bugbear":
                    return new Bugbear();

                case "choker":
                    return new Choker();

                case "cockatrice":
                    return new Cockatrice();

                case "darkmantle":
                    return new Darkmantle();

                case "direrat":
                    return new DireRat();

                case "firebeetle":
                    return new FireBeetle();

                case "gelatinouscube":
                    return new GelatinousCube();

                case "ghoul":
                    return new Ghoul();

                case "giantcentipede":
                    return new GiantCentipede();

                case "giantspider":
                    return new GiantSpider();

                case "goblin":
                    return new Goblin();

                case "grayooze":
                    return new GrayOoze();

                case "humanskeleton":
                    return new HumanSkeleton();

                case "mimic":
                    return new Mimic();

                case "ogre":
                    return new Ogre();

                case "rustmonster":
                    return new RustMonster();

                case "shadow":
                    return new Shadow();

                case "skeletalchampion":
                    return new SkeletalChampion();

                case "spiderswarm":
                    return new SpiderSwarm();

                case "strige":
                    return new Stirge();

                case "troglodyte":
                    return new Troglodyte();

                case "vargouille":
                    return new Vargouille();

                case "wight":
                    return new Wight();

                case "zombie":
                    return new Zombie();

                default:
                    return new Ogre();
            }
        }
    }
}
