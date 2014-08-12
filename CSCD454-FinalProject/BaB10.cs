using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Entitys
{
    class BaB10 : BaseAttackBonus
    {

        public int[] getBaB(int level)
        {
            int[] BaB;

            if ((level * 1) < 6)
            {
                BaB = new int[] { (level * 1) };
                return BaB;
            }
            else if ((level * 1) < 11)
            {
                BaB = new int[] { (level * 1), ((level - 5) * 1) };
                return BaB;
            }
            else if ((level * 1) < 16)
            {
                BaB = new int[] { (level * 1), ((level - 5) * 1), ((level - 10) * 1) };
                return BaB;
            }
            else
            {
                BaB = new int[] { (level * 1), ((level - 5) * 1), ((level - 10) * 1), ((level - 15) * 1) };
                return BaB;
            }
        }
    }
}


/*extra attacks per turn gained when BaB = 6, BaB = 11, BaB = 16
         *Extra attack bonus is equal to BaB - 5 (2nd attk), BaB - 10(third attk), BaB - 15(4th attk)
         *d10 and d12 for HD, +1 BAB each level (so level) "Barbarian, Fighter, Paladin, Ranger"
         *d8 for HD, +3/4 BAB each level (Floor(level*.75)) "Bard, Cleric, Druid, Monk, Rogue"
         *d6 for HD, +1/2 BAB each level (Floor(level*.5)) "Sorceror, Wizard"
        */