//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Project.Core.Constants;
//using Project.Web.Infrastructure.Services;
//using Project.Web.Models.Common;
//using System.Threading.Tasks;

//namespace Project.Web.Controllers.Api
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class SaveImageController : ControllerBase
//    {
//        #region Fields
//        private FileUploadStatusModel file;
//        private readonly IFileUploadService _fileUploadService;
//        private readonly IHttpContextAccessor _httpContextAccessor;

//        #endregion

//        #region Constructor

//        public SaveImageController(IFileUploadService fileUploadService, IHttpContextAccessor httpContextAccessor)
//        {
//            _fileUploadService = fileUploadService;
//            _httpContextAccessor = httpContextAccessor;
//        }

//        #endregion

//        #region Methods

//        [HttpPost]
//        public async Task<IActionResult> PostImage(IFormFile formFile, string FolderName)
//        {
//            string path = string.Empty;
//            switch (FolderName)
//            {
//                case "ManagerPhoto":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.ManagerPhoto);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "VendorAdharImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VendorAdharImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);

//                case "VendorCancelledChequeImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VendorCancelledChequeImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "CustomerPhoto":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.CustomerPhoto);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "VendorPanImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VendorPanImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "VehicleTypeImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VehicleTypeImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "CompanyContractDocument":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.CompanyContractDocument);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "CompanyLogo":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.CompanyLogo);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "VehicleImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VehicleImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "RCImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.RCImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "PUCImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.PUCImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "VehicleInsuranceImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.VehicleInsuranceImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "PermitImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.PermitImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "DriverImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.DriverImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "DriverLicenseImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.DriverLicenseImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "LRImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.LRImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "EwayBillImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.EwayBillImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "PODImgFrontImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.PODImgFrontImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);
//                case "PODImgBackImage":
//                    file = await _fileUploadService.Upload(formFile, DocUploadFolderNames.PODImgBackImage);
//                    if (file.Status == true)
//                    {
//                        path = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}/{file.UrlPath}";
//                    };
//                    return Ok(path);

//                default:
//                    return Ok(path);
//            }
//        }

//        #endregion
//    }
//}
