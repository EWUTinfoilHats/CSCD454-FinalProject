using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class Shield : Armor, Wieldable
    {
        public Shield() : base()
        {

        }

        public Wieldable GetBaseWieldable()
        {
            return this;
        }

        public int GetDamageRoll(int strength, bool isOffHand)
        {
            return 0;
        }

        public int GetCriticalDamageRoll(int strength, bool isOffHand)
        {
            return 0;
        }

        public int AttackMod
        {
            get { return 0; }
        }

        public int DamageMod
        {
            get { return 0; }
        }

        public int ThreatRangeMin
        {
            get { return 20; }
        }

        public int ThreatRangeMax
        {
            get { return 20; }
        }

        public bool IsInThreatRange(int roll)
        {
            return false;
        }

        public bool IsLight
        {
            get
            {
                return false;
            }
        }

        public bool IsWeapon()
        {
            return false;
        }
    }
}
