using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Items
{
    public abstract class Consumable : Item
    {
        public abstract bool Apply(Entity target);
    }
}
