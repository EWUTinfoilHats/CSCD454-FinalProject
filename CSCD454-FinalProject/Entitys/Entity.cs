using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Items.Weapons;

namespace CSCD454_FinalProject.Entitys
{
    public abstract class Entity
    {
        protected IList<int> attributes;
        public static readonly int innateAC = 10;

        //protected IList<Spell> spells;

        public Entity()
        {
            MainHand = Weapons.emptyHand;
            OffHand = Weapons.emptyHand;
            Armor = Armors.noArmor;
        }

        protected int[] BaB
        {
            get;
            set;
        }

        protected int[] SavingThrows
        {
            get;
            set;
        }

        public Armor Armor
        {
            get;
            private set;
        }

        public Armor SetArmor(Armor newArmor)
        {
            Armor oldArmor = Armor;
            if(newArmor == null)
            {
                newArmor = Armors.noArmor;
            }
            Armor = newArmor;
            return oldArmor;
        }

        public virtual int ArmorClass
        {
            get
            {
                return innateAC + Armor.ArmorClass + (int)Size + OffHand.ArmorClass + Math.Min(Math.Min(Attribute.GetAbilityMod(attributes[(int)Attributes.Dex]), Armor.MaxDexMod), OffHand.MaxDexMod);
            }
        }

        public int Mana
        {
            get;
            protected set;
        }

        public int ManaMax
        {
            get;
            protected set;
        }

        public bool AddMana(int amount)
        {
            if (Mana == ManaMax)
                return false;
            Mana = Math.Min(Mana + amount, ManaMax);
            return true;
        }

        public bool RemoveMana(int amount)
        {
            if (Mana < amount)
                return false;
            Mana -= amount;
            return true;
        }

        public int HP
        {
            get;
            protected set;
        }

        public int HPMax
        {
            get;
            protected set;
        }

        public bool AddHP(int amount)
        {
            if (IsDead() || HP == HPMax)
                return false;
            HP = Math.Min(HPMax, HP + amount);
            return true;
        }

        public bool RemoveHP(int amount)
        {
            if (IsDead())
                return false;
            HP -= amount;
            return true;
        }

        public int Initiative
        {
            get;
            protected set;
        }

        public int Level
        {
            get;
            protected set;
        }

        public Weapon MainHand
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newWep"></param>
        /// <returns>Returns an IList containing the old mainhand and offhand if the new weapon is 2h</returns>
        public IList<Wieldable> SetMainHand(Weapon newWep)
        {
            Weapon oldMH = MainHand;
            IList<Wieldable> returnVal = new Wieldable[] { oldMH };
            if(newWep == null)
            {
                newWep = Weapons.emptyHand;
            }
            if(newWep.Is2H)
            {
                returnVal.Add(OffHand);
                OffHand = Weapons.emptyHand;
            }
            MainHand = newWep;
            return returnVal;
        }

        public Wieldable OffHand
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newOH"></param>
        /// <returns>returns the passed in item if the MH is 2h and the orginally held item if not.</returns>
        public Wieldable SetOffHand(Wieldable newOH)
        {
            if(MainHand.Is2H)
            {
                return newOH;
            }
            if(newOH == null)
            {
                newOH = Weapons.emptyHand;
            }

            Wieldable old = OffHand;
            OffHand = newOH;
            return old;
        }

        public Size Size
        {
            get;
            protected set;
        }

        public virtual void Attack(Entity target)
        {
            //Mainhand
            foreach(int bonus in BaB)
            {
                AttackHelper(target, bonus, MainHand, false);
            }//end BAB loop

            //Offhand
            //TODO support for TWF feats
            AttackHelper(target, BaB[0], OffHand, true);

        }

        protected virtual void AttackHelper(Entity target, int BaB, Wieldable weapon, bool offhand)
        {
            Dice.Die d20 = Dice.D20.GetInstance();
            int attack = d20.Roll();
            if (attack == 1)//instant miss
                return;
            else if (attack == 20)//instant hit + threat
            {
                attack = d20.Roll() + GetAttackBonus(offhand, BaB);
                if (attack < target.ArmorClass)//nocrit
                {
                    target.RemoveHP(weapon.GetDamageRoll(attributes[(int)Attributes.Str], false));
                }
                else //crit
                {
                    target.RemoveHP(weapon.GetCriticalDamageRoll(attributes[(int)Attributes.Str], false));
                }
            }
            else
            {
                attack += GetAttackBonus(offhand, BaB);

                if (attack < target.ArmorClass)//miss
                    return;
                if (weapon.IsInThreatRange(attack))//attack is critical threat
                {
                    attack = d20.Roll() + GetAttackBonus(offhand, BaB);
                    if (attack < target.ArmorClass)//nocrit
                    {
                        target.RemoveHP(weapon.GetDamageRoll(attributes[(int)Attributes.Str], false));
                    }
                    else //crit
                    {
                        target.RemoveHP(weapon.GetCriticalDamageRoll(attributes[(int)Attributes.Str], false));
                    }
                }
                else
                {
                    target.RemoveHP(weapon.GetDamageRoll(attributes[(int)Attributes.Str], false));
                }
            }
        }

        protected virtual int GetAttackBonus(bool offhand, int BaB)
        {
            int hand = offhand ? 1 : 0;
            return Attribute.GetAbilityMod(attributes[(int)Attributes.Str]) + (int)Size + GetTWFBonus()[hand] + BaB;
        }

        public bool Has2H()
        {
            throw new NotImplementedException();
        }

        public bool IsDead()
        {
            return HP <= 0;
        }

        public int TouchArmorClass()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public virtual int[] GetTWFBonus()
        {
            //TODO support for TWF feats
            if(OffHand.IsWeapon() && OffHand.IsLight)
            {
                return new int[] { -4, -8 };
            }
            else if(OffHand.IsWeapon())
            {
                return new int[] { -6, -10 };
            }
            return new int[] { 0, 0 };
        }
    }
}
