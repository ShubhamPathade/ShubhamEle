using Project.Core;
using Project.Core.Data;
using Project.Core.Infrastructure;
using System.Threading.Tasks;

namespace Project.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields

        private readonly IDbContext _dbContext;

        #endregion

        #region Constructor

        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Methods

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            return EngineContext.Current.Resolve<IRepository<TEntity>>();
        }

        public async Task<int> SaveAsync()
        {
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        #endregion
    }
}
