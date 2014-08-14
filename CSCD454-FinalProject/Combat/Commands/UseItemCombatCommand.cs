using CSCD454_FinalProject.Items;

namespace CSCD454_FinalProject.Entitys.Commands
{
    public class UseItemCombatCommand : EntityCombatCommand
    {
        private Consumable item;
        public UseItemCombatCommand(Entity issuer, Consumable item) : base(issuer)
        {
            this.item = item;
        }

        public override void Do(CombatGroup targets)
        {
            //TODO add item removal logic once Inventory is in place
            if (item.Apply(targets.Target))
                issuer.RemoveItem(item);

        }
    }
}
