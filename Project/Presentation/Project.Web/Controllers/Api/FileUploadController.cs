//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using Project.Core.Domain.ProcedureModels;
//using Project.Web.Infrastructure.Services;
//using Project.Web.Models.Common;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace Project.Web.Controllers.Api
//{
//    [ApiController]
//    [Route("api/[controller]/[action]")]
//    public class FileUploadController : ControllerBase
//    {
//        #region Fields

//        private readonly IFileUploadService _fileUploadService;

//        #endregion

//        #region Constructor

//        public FileUploadController(IFileUploadService fileUploadService)
//        {
//            _fileUploadService = fileUploadService;
//        }

//        #endregion

//        #region Methods

//        [HttpPost]
//        public async Task<IActionResult> GetImageResponse([FromForm] UploadFileModel model)
//        {
//            var status = await _fileUploadService.Upload(model.File, model.FolderName);
//            return Ok(status);
//        }

//        [HttpPost]
//        public async Task<IActionResult> DownloadVendorLedger([FromForm] string vendorLedgerHeaderDetailModel,[FromForm] string vendorLedgerOrderItemDetailModels,[FromForm] string folderName)
//        {
//            var headerDetails = JsonConvert.DeserializeObject<VendorLedgerHeaderDetailModel>(vendorLedgerHeaderDetailModel);
//            var itemDetails = JsonConvert.DeserializeObject< IEnumerable<VendorLedgerOrderItemDetailModel>>(vendorLedgerOrderItemDetailModels);
//            var status = await _fileUploadService.DownloadVendorLedger(headerDetails,itemDetails, folderName);
//            return Ok(status);
//        }

//        #endregion
//    }
//}
