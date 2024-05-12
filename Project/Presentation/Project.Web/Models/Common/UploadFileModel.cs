using Microsoft.AspNetCore.Http;

namespace Project.Web.Models.Common
{
    public class UploadFileModel
    {
        #region Properties
        public string FolderName { get; set; }
        public IFormFile File { get; set; }

        #endregion
    }
}
