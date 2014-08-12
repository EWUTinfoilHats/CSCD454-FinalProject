using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public interface Wieldable
    {
        Wieldable GetBaseWieldable();

        int GetDamageRoll(int strength, bool isOffHand);

        int GetCriticalDamageRoll(int strength, bool isOffHand);

        bool IsLight
        {
            get;
        }

        int AttackMod
        {
            get;
        }

        int DamageMod
        {
            get;
        }

        int ThreatRangeMin
        {
            get;
        }

        int ThreatRangeMax
        {
            get;
        }

        string Type
        {
            get;
        }

        bool IsInThreatRange(int roll);

        int ArmorClass
        {
            get;
        }

        int MaxDexMod
        {
            get;
        }

        int ArcaneSpellFailure
        {
            get;
        }

        int ArmorCheckPenalty
        {
            get;
        }

        bool IsWeapon();
    }
}
