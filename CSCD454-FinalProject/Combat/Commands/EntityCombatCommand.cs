namespace CSCD454_FinalProject.Entitys.Commands
{
    public abstract class EntityCombatCommand
    {
        protected Entity issuer;
        public EntityCombatCommand(Entity issuer)
        {
            this.issuer = issuer;
        }

        public abstract void Do(CombatGroup targets);
    }
}
