using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class Weapon : Item, Wieldable
    {
        //TODO
        public Wieldable GetBaseWieldable()
        {
            return GetBaseWeapon();
        }

        public virtual Weapon GetBaseWeapon()
        {
            return this;
        }
    }
}
