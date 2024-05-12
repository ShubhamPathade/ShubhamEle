using System.Threading.Tasks;

namespace Project.Core.Data
{
    public interface IUnitOfWork
    {
        #region Methods

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;

        Task<int> SaveAsync();

        #endregion
    }
}
