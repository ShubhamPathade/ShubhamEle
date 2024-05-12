using Microsoft.EntityFrameworkCore;
using Project.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Project.Data
{
    public class ModelService<T> : IModelService<T> where T : BaseModel
    {
        #region Fields

        private readonly IDbContext _dbContext;

        #endregion

        #region Constructor

        public ModelService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Utilities

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

        public async Task<IEnumerable<T>> ModelFromSqlAsync(string sql, params object[] parameters)
        {
            sql = CreateSqlWithParameters(sql, parameters);
            var result = await _dbContext.SetModel<T>()
                 .FromSqlRaw(sql, parameters)
                 .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<T>> UpdateModelFromSqlAsync(string sql, params object[] parameters)
        {
            sql = CreateSqlWithParameters(sql, parameters);
            var result = await _dbContext.SetModel<T>()
                 .FromSqlRaw(sql, parameters)
                 .ToListAsync();
            return result;
        }

        #endregion
    }
}
