using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public class Armor : Item
    {
        public static readonly IList<string> ARMOR_TYPES = new string[] { "light", "medium", "heavy", "shield"};

        public Armor()
        {
            Type = "";
            MaxDexMod = 20;
        }

        public virtual int ArmorClass
        {
            get;
            protected set;
        }

        public Armor SetArmorClass(int AC)
        {
            if (ArmorClass == 0 && AC > 0)
            {
                ArmorClass = AC;
            }
            return this;
        }

        /// <summary>
        /// Defaults to 20 to indicate no max dex mod
        /// </summary>
        public virtual int MaxDexMod
        {
            get;
            protected set;
        }

        public Armor SetMaxDexMod(int mod)
        {
            if (MaxDexMod == 20 && mod >= 0)
            {
                MaxDexMod = mod;
            }
            return this;
        }

        public virtual int ArcaneSpellFailure
        {
            get;
            protected set;
        }

        public Armor SetArcaneSpellFailure(int chance)
        {
            if (ArcaneSpellFailure == 0 && chance >= 0)
            {
                ArcaneSpellFailure = chance;
            }
            return this;
        }

        /// <summary>
        /// Returns 0 or a negative number
        /// </summary>
        public virtual int ArmorCheckPenalty
        {
            get;
            protected set;
        }

        /// <summary>
        /// </summary>
        /// <param name="pen">Must be 0 or negative</param>
        /// <returns></returns>
        public Armor SetArmorCheckPenalty(int pen)
        {
            if(ArmorCheckPenalty == 0 && pen <= 0)
            {
                ArmorCheckPenalty = pen;
            }
            return this;
        }

        public virtual string Type
        {
            get;
            private set;
        }

        public Armor SetType(string type)
        {
            if(Type == "" && type != null && ARMOR_TYPES.Contains(type))
            {
                Type = type;
            }
            return this;
        }

        public virtual Armor GetBaseArmor()
        {
            return this;
        }

        public override string Description
        {
            get
            {
                return "A " + Name + ": " + ArmorClass + "AC, " + MaxDexMod + " max dex bonus, " + ArmorCheckPenalty + " armor check penalty, " + ArcaneSpellFailure + "% chance of arcane spell failure. Worth: " + Price + "g and weighing " + Weight + "lb";
            }
        }
    }
}
