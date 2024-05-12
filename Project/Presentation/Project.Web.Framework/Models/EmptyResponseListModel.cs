using System.Collections.Generic;

namespace Project.Web.Framework.Models
{
    public class EmptyResponseListModel
    {
        #region Constructor

        public EmptyResponseListModel()
        {
            Status = Status.Fail;
            Data = new List<object>();
        }

        #endregion

        #region Properties
        public Status Status { get; set; }
        public int OffSet { get; set; }
        public List<object> Data { get; set; }

        #endregion
    }
}
