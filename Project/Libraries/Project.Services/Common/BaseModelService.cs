using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
namespace Project.Services.Common
{
    public class BaseModelService
    {
        #region Fields
        private IList<DbParameter> _list;
        #endregion

        #region Constructor
        public BaseModelService()
        {
            _list = new List<DbParameter>();
        }
        #endregion

        #region Properties
        public DbParameter[] Parameters
        {
            get => _list.ToArray();
        }
        #endregion

        #region Methods
        protected void AddSqlParameter(string name, object value)
        {
            if (!string.IsNullOrWhiteSpace(name) && value != null)
            {
                _list.Add(new SqlParameter(name, value));
            }
        }
        protected void ClearAllParameters()
        {
            _list.Clear();
        }
        #endregion
    }
}