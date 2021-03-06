using System;
using System.Linq;
using System.Transactions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Application.Mapper;
using OnlineShopping.Persistence.EF;
using OnlineShopping.Persistence.EF.UnitOfWork;

namespace OnlineShopping.Application.Tests.Integration
{
    public abstract class IntegrationHookTest : IDisposable
    {
        private readonly TransactionScope _scope;
        protected readonly ApplicationDbContext DbContext;
        protected readonly UnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        protected IntegrationHookTest()
        {
            _scope = new TransactionScope();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer("Data Source=.;Initial Catalog=OnlineShoppingDb;Integrated Security=true");
            DbContext = new ApplicationDbContext(builder.Options);

            UnitOfWork = new UnitOfWork(DbContext);

            Mapper = new MapperConfiguration(mc =>
                mc.AddProfile(new AutoMapping())).CreateMapper();
        }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = this.DbContext.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }

        public void Dispose()
        {
            _scope.Dispose();
            DbContext.Dispose();
        }
    }
}