using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys
{
    public abstract class Player : Entity
    {
        protected IList<Item> inventory;
        protected ISet<Weapon> weaponProficies;

        public abstract void LevelUp();
    }
}
