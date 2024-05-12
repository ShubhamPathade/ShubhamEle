using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.Core;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Data
{
    /// <summary>
    /// Represents DB context
    /// </summary>
    public partial interface IDbContext
    {
        #region Methods

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        void DeleteEntity<TEntity>(TEntity entity) where TEntity : BaseEntity;

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        void InsertEntity<TEntity>(TEntity entity) where TEntity : BaseEntity;

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        void UpdateEntity<TEntity>(TEntity entity) where TEntity:BaseEntity;

        /// <summary>
        ///  Saves all changes made in this context to the database.
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a DbSet that can be used to query and save instances of entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>A set for the given entity type</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// Creates a model that can be used to query and save instances of entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>A set for the given entity type</returns>
        DbSet<TEntity> SetModel<TEntity>() where TEntity : BaseModel;

        /// <summary>
        /// Creates a LINQ query for the entity based on a raw SQL query
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="sql">The raw SQL query</param>
        /// <param name="parameters">The values to be assigned to parameters</param>
        /// <returns>An IQueryable representing the raw SQL query</returns>
        IQueryable<TEntity> EntityFromSql<TEntity>(string sql, params object[] parameters) where TEntity : BaseEntity;

        #endregion
    }
}
