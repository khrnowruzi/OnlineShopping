namespace OnlineShopping.Persistence.EF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Begin()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void Rollback()
        {
            _dbContext.Database.RollbackTransaction();
        }

        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}