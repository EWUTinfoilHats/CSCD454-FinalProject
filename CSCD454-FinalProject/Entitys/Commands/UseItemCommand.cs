using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys.Commands
{
    public class UseItemCommand : EntityCommand
    {
        private Consumable item;
        public UseItemCommand(Entity issuer, Consumable item) : base(issuer)
        {
            this.item = item;
        }

        public override void Do(Entity target)
        {
            //TODO add item removal logic once Inventory is in place
            if (item.Apply(target))
                issuer.RemoveItem(item);

        }
    }
}
