using System.Collections.Generic;

namespace Project.Web.Models.Common
{
    //public abstract class BaseDatatableListModel<T> where T : BaseEntityModel
    public class BaseDatatableListModel<T> 
    {
        #region Constructor

        public BaseDatatableListModel()
        {
            Data = new List<T>();
        }

        #endregion

        #region Properties

        public int Draw { get; set; }
        public IEnumerable<T> Data { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }

        #endregion
    }
}
