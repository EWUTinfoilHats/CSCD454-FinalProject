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
        public static readonly string[] WEAPON_TYPES = new string[] {"exotic", "martial", "simple" };

        public Weapon() : base()
        {
            ThreatRangeMax = 20;
            ThreatRangeMin = 20;
            DamageDice = new Die[0];
            Type = "";
        }

        public virtual int CriticalMultiplier
        {
            get;
            private set;
        }

        public Weapon SetCriticalMultiplier(int mult)
        {
            if (CriticalMultiplier == 0)
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
            if (DamageDice.Count == 0)
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
            if (DamageMod == 0)
                DamageMod = dm;
            return this;
        }

        public bool Is2H
        {
            get;
            private set;
        }

        public Weapon SetIs2H(bool is2h)
        {
            if (Is2H == false)
                Is2H = is2h;
            return this;
        }

        public bool IsLight
        {
            get;
            private set;
        }

        public Weapon SetIsLight(bool light)
        {
            if (IsLight == false)
                IsLight = light;
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

        public Weapon SetThreatRange(int min, int max)
        {
            if(ThreatRangeMax == 20 && ThreatRangeMin == 20)
            {
                ThreatRangeMin = min;
                ThreatRangeMax = max;
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
    }
}
