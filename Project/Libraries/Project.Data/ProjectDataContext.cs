using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.Core;
using Project.Data.Mapping;
using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Project.Data
{
    public class ProjectDataContext : DbContext, IDbContext
    {
        #region Constructor

        public ProjectDataContext(DbContextOptions options) : base(options)
        {
        }

        #endregion

        #region Utilities        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuring entity framework models

            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
               (type.BaseType?.IsGenericType ?? false)
                   && (type.BaseType.GetGenericTypeDefinition() == typeof(ProjectEntityTypeConfiguration<>)));

            foreach (var typeConfiguration in typeConfigurations)
            {

                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            #endregion

            ModelMappingRegistrar.Register(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Modify the input SQL query by adding passed parameters
        /// </summary>
        /// <param name="sql">The raw SQL query</param>
        /// <param name="parameters">The values to be assigned to parameters</param>
        /// <returns>Modified raw SQL query</returns>
        protected virtual string CreateSqlWithParameters(string sql, params object[] parameters)
        {
            //add parameters to sql
            for (var i = 0; i <= (parameters?.Length ?? 0) - 1; i++)
            {
                if (!(parameters[i] is DbParameter parameter))
                    continue;

                sql = $"{sql}{(i > 0 ? "," : string.Empty)} @{parameter.ParameterName}";

                //whether parameter is output
                if (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Output)
                    sql = $"{sql} output";
            }

            return sql;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates a DbSet that can be used to query and save instances of entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>A set for the given entity type</returns>
        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        /// <summary>
        /// Creates a ef model that can be used to query and save instances of entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>A set for the given entity type</returns>
        public DbSet<TEntity> SetModel<TEntity>() where TEntity : BaseModel
        {
            return base.Set<TEntity>();
        }

        /// <summary>
        /// Creates a LINQ query for the entity based on a raw SQL query
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <param name="sql">The raw SQL query</param>
        /// <param name="parameters">The values to be assigned to parameters</param>
        /// <returns>An IQueryable representing the raw SQL query</returns>
        public IQueryable<TEntity> EntityFromSql<TEntity>(string sql, params object[] parameters) where TEntity : BaseEntity
        {
            //this.Database.ExecuteSqlCommand
            var result = this.Set<TEntity>().FromSqlRaw(sql, parameters);
            return result;
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        public void UpdateEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            base.Update<TEntity>(entity);
        }

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        public void DeleteEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            base.Remove<TEntity>(entity);
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns></returns>
        public void InsertEntity<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            base.Add<TEntity>(entity);
        }

        #endregion
    }
}
