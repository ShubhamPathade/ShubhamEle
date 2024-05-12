namespace Project.Web.Models.Common
{
    public class FileUploadStatusModel
    {
        #region Properties
        public bool Status { get; set; }
        public string Path { get; set; }
        public string UrlPath { get; set; }
        public string ErrorMessage { get; set; }

        #endregion
    }
}
