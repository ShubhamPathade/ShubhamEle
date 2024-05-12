using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Core.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Methods

        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<int> SaveChangeAsync();
        Task<IList<TEntity>> EntityFromSql(string sql, params object[] parameters);

        #endregion

        #region Properties

        IQueryable<TEntity> Table { get; }


        #endregion
    }
}
