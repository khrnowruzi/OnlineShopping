namespace OnlineShopping.Persistence.EF.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Begin();
        void Rollback();
        void Complete();
    }
}