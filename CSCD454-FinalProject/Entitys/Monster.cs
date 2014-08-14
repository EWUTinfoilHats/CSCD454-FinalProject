using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Items;
using CSCD454_FinalProject.Entitys.Enemies;

namespace CSCD454_FinalProject.Entitys
{
    public abstract class Monster : Entity, MonsterPrototype
    {
        protected ISet<Weapon> weaponProficiencies;

        public abstract Monster Clone();
    }
}
