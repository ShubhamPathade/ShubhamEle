using Project.Core;
using System.Collections.Generic;

namespace Project.Web.Framework.Models
{
    public class BaseResponseListModel<T> where T : BaseModel
    {
        #region Constructor

        public BaseResponseListModel()
        {
            Data = new List<T>();
        }

        #endregion

        #region Properties

        public int OffSet { get; set; }
        public Status Status { get; set; }
        public IEnumerable<T> Data { get; set; }

        #endregion
    }
}
