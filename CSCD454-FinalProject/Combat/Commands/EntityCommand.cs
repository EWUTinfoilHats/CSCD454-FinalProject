namespace CSCD454_FinalProject.Entitys.Commands
{
    public abstract class EntityCommand
    {
        protected Entity issuer;
        public EntityCommand(Entity issuer)
        {
            this.issuer = issuer;
        }

        public abstract void Do(CombatGroup targets);
    }
}
