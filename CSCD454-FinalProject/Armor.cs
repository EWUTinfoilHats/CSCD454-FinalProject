using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class Armor : Item
    {
        public int ArmorClass
        {
            get;
            protected set;
        }

        public int MaxDexMod
        {
            get;
            protected set;
        }

        public int ArcaneSpellFailure
        {
            get;
            protected set;
        }

        public virtual Armor GetBaseArmor()
        {
            return this;
        }
    }
}
