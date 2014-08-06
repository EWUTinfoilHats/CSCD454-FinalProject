using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class Item
    {
        public string Name
        {
            get;
            protected set;
        }

        public int Price
        {
            get;
            protected set;
        }

        public int Weight
        {
            get;
            protected set;
        }


    }
}
