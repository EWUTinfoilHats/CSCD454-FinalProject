using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject
{

    public class Attribute
    {
        public static int GetAbilityMod(int attr)
        {
            return (int)Math.Floor((attr - 10) / 2.0);
        }
    }

    public enum Attributes
    {
        Str,
        Dex,
        Con,
        Int,
        Wis,
        Cha
    };
}
