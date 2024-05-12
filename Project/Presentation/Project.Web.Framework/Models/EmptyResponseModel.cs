namespace Project.Web.Framework.Models
{
    public class EmptyResponseModel
    {
        #region Constructor

        public EmptyResponseModel()
        {
            Data = new object();
        }

        #endregion

        #region Properties
        public Status Status { get; set; }
        public string Message { get; set; } = string.Empty;
        public object Data { get; set; }

        #endregion
    }
}
