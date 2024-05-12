namespace Project.Web.Models.Common
{
    public abstract class BaseDatatableSearchModel
    {
        #region Properties
        public int PageIndex
        {
            get
            {
                var pageIndex = 0;
                if (Start != 0)
                {
                    pageIndex = (Start / Length);
                }
                return pageIndex;
            }
        }
        public int Start { get; set; }
        public int Draw { get; set; }
        public int Length { get; set; }
        #endregion
    }
}
