using Microsoft.EntityFrameworkCore;
using Project.Core;
using Project.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Fields

        private readonly IDbContext _dbContext;
        private DbSet<TEntity> _entities;

        #endregion

        #region Constructor

        public EfRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Properties

        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _dbContext.Set<TEntity>();

              //  _dbContext.EntityFromSql("exec sp_GetUsers @emailAddress",)

                return _entities;
            }
        }

        public IQueryable<TEntity> Table => this.Entities;

        #endregion

        #region Methods

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var list = await Entities.ToListAsync();
            return list;
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            var entity = await  Entities.FindAsync(id);
            return entity;
        }

        public async Task<IList<TEntity>> EntityFromSql(string sql, params object[] parameters)
        {
            var result =  _dbContext.EntityFromSql<TEntity>(sql, parameters);
            return await result.ToListAsync();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbContext.DeleteEntity(entity);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbContext.InsertEntity(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbContext.UpdateEntity(entity);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        #endregion
    }
}
