using Microsoft.Data.SqlClient;
using Project.Core;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Project.Data
{
    public interface IModelService<T> where T : BaseModel
    {
        #region Methods

        Task<IEnumerable<T>> ModelFromSqlAsync(string sql, params object[] parameters);
        Task<IEnumerable<T>> UpdateModelFromSqlAsync(string sql, params object[] parameters);

        #endregion
    }
}
