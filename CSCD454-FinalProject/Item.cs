using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Items
{
    public abstract class Item
    {
        public Item()
        {
            Name = "";
        }

        public virtual string Name
        {
            get;
            private set;
        }

        public Item SetName(string name)
        {
            if (Name == "")
                Name = name;
            return this;
        }

        public int Price
        {
            get;
            private set;
        }

        public Item SetPrice(int price)
        {
            if (Price == 0)
                Price = price;
            return this;
        }

        public int Weight
        {
            get;
            private set;
        }

        public Item SetWeight(int weight)
        {
            if (Weight == 0)
                Weight = weight;
            return this;
        }

        public virtual string Description
        {
            get
            {
                return "A " + Name + " weighing " + Weight + " worth " + Price + "gold.";
            }
        }
    }
}
