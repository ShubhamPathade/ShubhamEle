using Project.Core;

namespace Project.Web.Framework.Models
{
    public class BaseResponseModel<T>  where T : BaseModel
    {
        #region Properties

        public string Message { get; set; } = string.Empty;
        public Status Status { get; set; }
        public T Data { get; set; }

        #endregion
    }
}
