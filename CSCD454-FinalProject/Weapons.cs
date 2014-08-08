using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Dice;

namespace CSCD454_FinalProject.Items.Weapons
{
    class Weapons
    {
        public static readonly Weapon emptyHand = (Weapon)(new Weapon()).SetDamageDice(new Die[] { D0.GetInstance() }).SetType("simple").SetName("Empty Hand");
        //TODO more weapons
    }
}
