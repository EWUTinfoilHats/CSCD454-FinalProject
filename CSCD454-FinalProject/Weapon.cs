using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items
{
    /// <summary>
    /// Weapon class. Use method chaining with the Set methods to set the properties to the desired state.
    /// Set methods only allow setting of a weapons properites once.
    /// ThreatRange defaults to 20
    /// </summary>
    public class Weapon : Item, Wieldable
    {
        public static readonly IList<string> WEAPON_TYPES = new string[] {"exotic", "martial", "simple" };

        public Weapon() : base()
        {
            ThreatRangeMax = 20;
            ThreatRangeMin = 20;
            DamageDice = new Die[0];
            CriticalMultiplier = 2;
            Type = "";
        }

        public virtual int CriticalMultiplier
        {
            get;
            private set;
        }

        public Weapon SetCriticalMultiplier(int mult)
        {
            if (CriticalMultiplier == 2 && mult > 0)
                CriticalMultiplier = mult;
            return this;
        }

        public virtual IList<Die> DamageDice
        {
            get;
            private set;
        }

        public Weapon SetDamageDice(IList<Die> dice)
        {
            if (DamageDice.Count == 0 && dice != null)
                DamageDice = dice;
            return this;
        }

        public virtual int DamageMod
        {
            get;
            private set;
        }

        public Weapon SetDamageMod(int dm)
        {
            if (DamageMod == 0 && dm >= 0)
                DamageMod = dm;
            return this;
        }

        public virtual int AttackMod
        {
            get;
            private set;
        }

        public Weapon SetAttackMod(int am)
        {
            if (AttackMod == 0 && am >= 0)
                AttackMod = am;
            return this;
        }

        public bool Is2H
        {
            get;
            private set;
        }

        public Weapon Set2H()
        {
            Is2H = true;
            return this;
        }

        public bool IsLight
        {
            get;
            private set;
        }

        public Weapon SetLight()
        {
            IsLight = true;
            return this;
        }

        public virtual int ThreatRangeMin
        {
            get;
            private set;
        }

        public virtual int ThreatRangeMax
        {
            get;
            private set;
        }

        public Weapon SetThreatRange(int min)
        {
            if(ThreatRangeMax == 20 && ThreatRangeMin == 20 && min >= 0 && min <= 20)
            {
                ThreatRangeMin = min;
            }
            return this;
        }

        public string Type
        {
            get;
            private set;
        }

        public Weapon SetType(string type)
        {
            if(Type == "")
            {
                string tmp = type.ToLower();
                if(WEAPON_TYPES.Contains(tmp))
                {
                    Type = tmp;
                }
            }
            return this;
        }

        public Wieldable GetBaseWieldable()
        {
            return GetBaseWeapon();
        }

        public virtual Weapon GetBaseWeapon()
        {
            return this;
        }

        public bool IsInThreatRange(int roll)
        {
            return roll >= ThreatRangeMin && roll <= ThreatRangeMax;
        }

        public virtual int GetDamageRoll(int strength, bool isOffhand)
        {
            return DamageHelper(strength, isOffhand);
        }

        protected virtual int DamageHelper(int strength, bool isOffhand)
        {
            int strMod = Attribute.GetAbilityMod(strength);

            double damage = 0;

            foreach (Die d in DamageDice)
            {
                damage += d.Roll();
            }

            if (strMod < 0)
            {
                damage += strMod; //Offhand and 2h don't get multipliers for neg
            }
            else if (isOffhand)
            {
                damage += strMod / 2.0;
            }
            else if (Is2H)
            {
                damage += strMod * 1.5;
            }
            else
            {
                damage += strMod;
            }

            return Math.Max((int)Math.Floor(damage + DamageMod), 1);
        }

        public virtual int GetCriticalDamageRoll(int strength, bool isOffhand)
        {
            int damage = 0;

            for (int i = 0; i < CriticalMultiplier; i++)
            {
                damage += DamageHelper(strength, isOffhand);
            }
            return damage;
        }
    }
}
