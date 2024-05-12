using IronBarCode;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Web.Infrastructure.Services
{
    public class FileUploadService : IFileUploadService
    {
        //#region Properties

        //private FileUploadStatusModel _fileUpload;
        //private readonly IWebHostEnvironment _hostingEnvironment;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //#endregion

        //#region Constructor

        //public FileUploadService(IHttpContextAccessor httpContextAccessor,
        //    IWebHostEnvironment hostingEnvironment)
        //{
        //    _fileUpload = new FileUploadStatusModel();
        //    _hostingEnvironment = hostingEnvironment;
        //    _httpContextAccessor = httpContextAccessor;
        //}

        //#endregion

        //#region Utilities

        //public static string ConvertAmount(long amount)
        //{
        //    try
        //    {
        //        long amount_dec = ((amount - (amount)) * 100);
        //        if (amount_dec == 0)
        //        {
        //            return ConvertToWords(amount) + " Only.";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        // TODO: handle exception  
        //    }
        //    return "";
        //}
        //public static string ConvertToWords(long i)
        //{
        //    string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        //    string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        //    if (i < 20)
        //    {
        //        return units[i];
        //    }
        //    if (i < 100)
        //    {
        //        return tens[i / 10] + ((i % 10 > 0) ? " " + ConvertToWords(i % 10) : "");
        //    }
        //    if (i < 1000)
        //    {
        //        return units[i / 100] + " Hundred" + ((i % 100 > 0) ? " And " + ConvertToWords(i % 100) : "");
        //    }
        //    if (i < 100000)
        //    {
        //        return ConvertToWords(i / 1000) + " Thousand " + ((i % 1000 > 0) ? " " + ConvertToWords(i % 1000) : "");
        //    }
        //    if (i < 10000000)
        //    {
        //        return ConvertToWords(i / 100000) + " Lakh " + ((i % 100000 > 0) ? " " + ConvertToWords(i % 100000) : "");
        //    }
        //    if (i < 1000000000)
        //    {
        //        return ConvertToWords(i / 10000000) + " Crore " + ((i % 10000000 > 0) ? " " + ConvertToWords(i % 10000000) : "");
        //    }
        //    return ConvertToWords(i / 1000000000) + " Arab " + ((i % 1000000000 > 0) ? " " + ConvertToWords(i % 1000000000) : "");
        //}

        //#endregion

        //#region Methods

        //public async Task<FileUploadStatusModel> Upload(IFormFile file, string folderName)
        //{
        //    if (file == null || file.Length == 0)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string basePath = Path.Combine(_hostingEnvironment.WebRootPath, folderName);
        //    if (!Directory.Exists(basePath))
        //    {
        //        Directory.CreateDirectory(basePath);
        //    }

        //    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file.FileName);
        //    var extension = Path.GetExtension(file.FileName);
        //    var fileName = $"{fileNameWithoutExtension}_{DateTime.Now:yyyyMMddhhmmss}{extension}";

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, fileName);

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + fileName;        //for server Web
        //        _fileUpload.UrlPath = BaseUrl + "/B2BAdmin/" + folderName + "/" + fileName;        //for server Api
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + fileName;        //for Local Web
        //        _fileUpload.UrlPath = BaseUrl + "/" + folderName + "/" + fileName;        //for Local Api
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> UploadExcel(IEnumerable<RequisitionReportExcelModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Requisition_Report_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> CreateAndWriteExcel(IEnumerable<InvoiceItemUIModel> invoiceItemUIModel, InvoiceHeaderDetailUIModel invoiceHeaderDetailUIModel, string folderName)
        //{
        //    if (invoiceItemUIModel == null && invoiceItemUIModel.Count() > 0 && invoiceHeaderDetailUIModel == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, "InvoiceTemplate.xlsx");

        //    var newFilePath = $"{DateTime.UtcNow.ToString("yyyyMMddhhmmss")}_{invoiceHeaderDetailUIModel.InvoiceNo}.xlsx";

        //    var newPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, newFilePath);

        //    await Task.Yield();

        //    var file = new FileInfo(path);

        //    if (file.Exists)
        //    {
        //        int currentRow = 19;

        //        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //        using (ExcelPackage excelPackage = new ExcelPackage(path))
        //        {
        //            ExcelWorksheet ws = excelPackage.Workbook.Worksheets.First();

        //            ws.Cells[13, 11].Value = invoiceHeaderDetailUIModel.BaseAmount;
        //            ws.Cells[14, 11].Value = invoiceHeaderDetailUIModel.TaxAmount;
        //            ws.Cells[15, 11].Value = invoiceHeaderDetailUIModel.TotalAmount;
        //            ws.Cells[11, 11].Value = invoiceHeaderDetailUIModel.InvoiceDate;
        //            ws.Cells[8, 11].Value = invoiceHeaderDetailUIModel.InvoiceNo;
        //            ws.Cells[16, 2].Value = ConvertToWords(Convert.ToInt64(invoiceHeaderDetailUIModel.TotalAmount));
        //            ws.Cells[7, 2].Value = invoiceHeaderDetailUIModel.CompanyName;
        //            ws.Cells[8, 2].Value = invoiceHeaderDetailUIModel.CompanyAddress;

        //            foreach (var item in invoiceItemUIModel)
        //            {
        //                decimal total = 0;
        //                total = (decimal)(total + (item.ContractRate == null || item.ContractRate > 0 ? item.ContractRate : 0));
        //                total = (decimal)(total + (item.LUAmount != null || item.LUAmount > 0 ? item.LUAmount : 0));
        //                total = (decimal)(total + (item.DetentionAmount != null || item.DetentionAmount > 0 ? item.DetentionAmount : 0));

        //                ws.Cells[currentRow, 1].Value = item.OrderNo;
        //                ws.Cells[currentRow, 2].Value = item.TruckNumber;
        //                ws.Cells[currentRow, 3].Value = item.PickUpDate;
        //                ws.Cells[currentRow, 4].Value = item.VehicleType;
        //                ws.Cells[currentRow, 5].Value = item.PickupPoint;
        //                ws.Cells[currentRow, 6].Value = item.DropPoint;
        //                ws.Cells[currentRow, 7].Value = item.LRNumber;
        //                ws.Cells[currentRow, 8].Value = item.ContractRate;
        //                ws.Cells[currentRow, 9].Value = item.LUAmount;
        //                ws.Cells[currentRow, 10].Value = item.DetentionAmount;
        //                ws.Cells[currentRow, 11].Value = total;
        //                currentRow++;
        //            }

        //            excelPackage.SaveAs(newPath);
        //        }
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + newFilePath;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + newFilePath;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> UploadInvoice(IFormFile file, string folderName, long invoiceId)
        //{
        //    if (file == null || file.Length == 0)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }
        //    var extension = Path.GetExtension(file.FileName);
        //    var fileName = $"{DateTime.Now:yyyyMMddhhmmss}_{invoiceId}{extension}";

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, fileName);

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + fileName;        //for server Web
        //        _fileUpload.UrlPath = BaseUrl + "/B2BAdmin/" + folderName + "/" + fileName;        //for server Api
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + fileName;        //for Local Web
        //        _fileUpload.UrlPath = BaseUrl + "/" + folderName + "/" + fileName;        //for Local Api
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadVendorLedger(VendorLedgerHeaderDetailModel vendorLedgerHeaderDetailModel, IEnumerable<VendorLedgerOrderItemDetailModel> vendorLedgerOrderItemDetailModels, string folderName)
        //{

        //    #region New Code
        //    //if (vendorLedgerHeaderDetailModel == null) 
        //    //{
        //    //    _fileUpload.Status = false;
        //    //    _fileUpload.ErrorMessage = "file not selected";
        //    //    return _fileUpload;
        //    //}

        //    //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, "VendorLedgerTemplateNew.xlsx");

        //    //var newFilePath = $"VendorLedger_{DateTime.UtcNow.ToString("yyyyMMddhhmmss")}.xlsx";

        //    //var newPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, newFilePath);

        //    //await Task.Yield();

        //    //var file = new FileInfo(path);

        //    //if (file.Exists)
        //    //{
        //    //    int currentRow = 16;

        //    //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    //    using (ExcelPackage excelPackage = new ExcelPackage(path))
        //    //    {
        //    //        ExcelWorksheet ws = excelPackage.Workbook.Worksheets.First();

        //    //        ws.Cells[4, 3].Value = vendorLedgerHeaderDetailModel.FromDate;
        //    //        ws.Cells[4, 6].Value = vendorLedgerHeaderDetailModel.ToDate;
        //    //        ws.Cells[7, 2].Value = vendorLedgerHeaderDetailModel.VendorCompanyName;
        //    //        ws.Cells[9, 2].Value = vendorLedgerHeaderDetailModel.VendorAddress;
        //    //        ws.Cells[8, 7].Value = vendorLedgerHeaderDetailModel.AdvanceReceived;
        //    //        ws.Cells[8, 8].Value = vendorLedgerHeaderDetailModel.AdvancePending;
        //    //        ws.Cells[9, 7].Value = vendorLedgerHeaderDetailModel.BalanceReceived;
        //    //        ws.Cells[9, 8].Value = vendorLedgerHeaderDetailModel.BalancePending;
        //    //        ws.Cells[6, 8].Value = vendorLedgerHeaderDetailModel.TotalEarning;
        //    //        ws.Cells[10, 8].Value = vendorLedgerHeaderDetailModel.TotalPending;
        //    //        ws.Cells[11, 8].Value = vendorLedgerHeaderDetailModel.DebitRate;
        //    //        ws.Cells[12, 8].Value = vendorLedgerHeaderDetailModel.LRChargeAmount;
        //    //        ws.Cells[13, 8].Value = vendorLedgerHeaderDetailModel.TotalOutstanding;

        //    //        foreach (var item in vendorLedgerOrderItemDetailModels)
        //    //        {

        //    //            ws.Cells[currentRow, 1].Value = item.OrderNo;
        //    //            //ws.Cells[currentRow, 2].Value = item.CompanyName;
        //    //            ws.Cells[currentRow, 2].Value = item.ServiceType;
        //    //            ws.Cells[currentRow, 3].Value = item.PickUpDate;
        //    //            ws.Cells[currentRow, 4].Value = item.VehicleType;
        //    //            ws.Cells[currentRow, 5].Value = item.TruckNumber;
        //    //            ws.Cells[currentRow, 6].Value = item.DriverNumber;
        //    //            ws.Cells[currentRow, 7].Value = item.PickupPoint;
        //    //            ws.Cells[currentRow, 8].Value = item.DropPoint;
        //    //            ws.Cells[currentRow, 9].Value = item.LRNumber;
        //    //            ws.Cells[currentRow, 10].Value = item.EwayBillNumber;
        //    //            ws.Cells[currentRow, 11].Value = item.VendorRate;
        //    //            ws.Cells[currentRow, 12].Value = item.AdvanceAmount;
        //    //            ws.Cells[currentRow, 13].Value = item.AdvanceUTR;
        //    //            ws.Cells[currentRow, 14].Value = item.AdvanceDate;
        //    //            ws.Cells[currentRow, 15].Value = item.DebitRate;
        //    //            ws.Cells[currentRow, 16].Value = item.DebitRemark;
        //    //            ws.Cells[currentRow, 17].Value = item.BalenceAmount;
        //    //            ws.Cells[currentRow, 18].Value = item.BalanceUTR;
        //    //            ws.Cells[currentRow, 19].Value = item.BalanceDate;
        //    //            ws.Cells[currentRow, 20].Value = item.DifferenceAmount;
        //    //            ws.Cells[currentRow, 21].Value = item.PODStatus;
        //    //            ws.Cells[currentRow, 22].Value = item.PodDate;
        //    //            ws.Cells[currentRow, 23].Value = item.LRChargeAmount;
        //    //            ws.Cells[currentRow, 24].Value = item.Remark;
        //    //            currentRow++;
        //    //        }

        //    //        excelPackage.SaveAs(newPath);
        //    //    }
        //    //}

        //    //var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    //_fileUpload.Status = true;
        //    //if (_hostingEnvironment.IsProduction())
        //    //{
        //    //    _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + newFilePath;        //for server Web
        //    //}
        //    //else
        //    //{
        //    //    _fileUpload.Path = BaseUrl + "/" + folderName + "/" + newFilePath;        //for Local Web
        //    //}
        //    //return _fileUpload;
        //    #endregion


        //    #region Old Code

        //    if (vendorLedgerHeaderDetailModel == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, "VendorLedgerTemplate.xlsx");

        //    var newFilePath = $"VendorLedger_{DateTime.UtcNow.ToString("yyyyMMddhhmmss")}.xlsx";

        //    var newPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, newFilePath);

        //    await Task.Yield();

        //    var file = new FileInfo(path);

        //    if (file.Exists)
        //    {
        //        int currentRow = 16;

        //        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //        using (ExcelPackage excelPackage = new ExcelPackage(path))
        //        {
        //            ExcelWorksheet ws = excelPackage.Workbook.Worksheets.First();

        //            ws.Cells[4, 3].Value = vendorLedgerHeaderDetailModel.FromDate;
        //            ws.Cells[4, 6].Value = vendorLedgerHeaderDetailModel.ToDate;
        //            ws.Cells[7, 2].Value = vendorLedgerHeaderDetailModel.VendorCompanyName;
        //            ws.Cells[9, 2].Value = vendorLedgerHeaderDetailModel.VendorAddress;
        //            ws.Cells[8, 6].Value = vendorLedgerHeaderDetailModel.AdvanceReceived;
        //            ws.Cells[8, 7].Value = vendorLedgerHeaderDetailModel.AdvancePending;
        //            ws.Cells[9, 6].Value = vendorLedgerHeaderDetailModel.BalanceReceived;
        //            ws.Cells[9, 7].Value = vendorLedgerHeaderDetailModel.BalancePending;
        //            ws.Cells[6, 7].Value = vendorLedgerHeaderDetailModel.TotalEarning;
        //            ws.Cells[10, 7].Value = vendorLedgerHeaderDetailModel.TotalPending;
        //            ws.Cells[11, 7].Value = vendorLedgerHeaderDetailModel.DebitRate;
        //            ws.Cells[12, 7].Value = vendorLedgerHeaderDetailModel.LRChargeAmount;
        //            ws.Cells[13, 7].Value = vendorLedgerHeaderDetailModel.TotalOutstanding;

        //            foreach (var item in vendorLedgerOrderItemDetailModels)
        //            {

        //                ws.Cells[currentRow, 1].Value = item.OrderNo;
        //                //ws.Cells[currentRow, 2].Value = item.CompanyName;
        //                ws.Cells[currentRow, 2].Value = item.PickUpDate;
        //                ws.Cells[currentRow, 3].Value = item.VehicleType;
        //                ws.Cells[currentRow, 4].Value = item.TruckNumber;
        //                ws.Cells[currentRow, 5].Value = item.DriverNumber;
        //                ws.Cells[currentRow, 6].Value = item.PickupPoint;
        //                ws.Cells[currentRow, 7].Value = item.DropPoint;
        //                ws.Cells[currentRow, 8].Value = item.LRNumber;
        //                ws.Cells[currentRow, 9].Value = item.EwayBillNumber;
        //                ws.Cells[currentRow, 10].Value = item.VendorRate;
        //                ws.Cells[currentRow, 11].Value = item.AdvanceAmount;
        //                ws.Cells[currentRow, 12].Value = item.AdvanceUTR;
        //                ws.Cells[currentRow, 13].Value = item.AdvanceDate;
        //                ws.Cells[currentRow, 14].Value = item.DebitRate;
        //                ws.Cells[currentRow, 15].Value = item.DebitRemark;
        //                ws.Cells[currentRow, 16].Value = item.BalenceAmount;
        //                ws.Cells[currentRow, 17].Value = item.BalanceUTR;
        //                ws.Cells[currentRow, 18].Value = item.BalanceDate;
        //                ws.Cells[currentRow, 19].Value = item.DifferenceAmount;
        //                ws.Cells[currentRow, 20].Value = item.PODStatus;
        //                ws.Cells[currentRow, 21].Value = item.PodDate;
        //                ws.Cells[currentRow, 22].Value = item.LRChargeAmount;
        //                currentRow++;
        //            }

        //            excelPackage.SaveAs(newPath);
        //        }
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + newFilePath;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + newFilePath;        //for Local Web
        //    }
        //    return _fileUpload;

        //    #endregion

        //}

        //#region Download report section

        //public async Task<FileUploadStatusModel> DownloadPodReport(IEnumerable<DownloadPodReportModel> model, string folderName)
        //{
        //    try
        //    {


        //        if (model == null)
        //        {
        //            _fileUpload.Status = false;
        //            _fileUpload.ErrorMessage = "file not selected";
        //            return _fileUpload;
        //        }

        //        string excelName = $"POD_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //        FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //        if (file.Exists)
        //        {
        //            file.Delete();
        //            file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //        }

        //        // query data from database  
        //        await Task.Yield();
        //        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //        using (var package = new ExcelPackage(file))
        //        {
        //            var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //            workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //            package.Save();
        //        }

        //        var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //        _fileUpload.Status = true;
        //        if (_hostingEnvironment.IsProduction())
        //        {
        //            _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //        }
        //        else
        //        {
        //            _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //        }
        //        return _fileUpload;
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //        throw;
        //    }
        //}

        //public async Task<FileUploadStatusModel> DownloadTripReport(IEnumerable<DownloadTripReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Trip_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadCancelTripReport(IEnumerable<DownloadCancelTripReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Cancel_Trip_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadVendorLedgerTripReport(IEnumerable<DownloadVendorLedgerTripReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"VendorLedger_Trip_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadB2BInvoiceTripReport(IEnumerable<DownloadB2BInvoiceTripReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Invoice_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadSMEInvoiceTripReport(IEnumerable<DownloadSMEInvoiceTripReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Invoice_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadExpenseReport(IEnumerable<DownloadExpenseReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"Expense_Report_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadPtlPodReport(IEnumerable<DownloadPtlPodReportModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"POD_Report_PTL{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //}

        //public async Task<FileUploadStatusModel> DownloadPtlVendorLedgerTripReport(IEnumerable<DownloadVendorLedgerTripReportPtlModel> model, string folderName)
        //{
        //    if (model == null)
        //    {
        //        _fileUpload.Status = false;
        //        _fileUpload.ErrorMessage = "file not selected";
        //        return _fileUpload;
        //    }

        //    string excelName = $"VendorLedger_Trip_Report_PTL_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";

        //    FileInfo file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    if (file.Exists)
        //    {
        //        file.Delete();
        //        file = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName, excelName));
        //    }

        //    // query data from database  
        //    await Task.Yield();
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (var package = new ExcelPackage(file))
        //    {
        //        var workSheet = package.Workbook.Worksheets.Add("Sheet1");
        //        workSheet.Cells.LoadFromCollection(model, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        package.Save();
        //    }

        //    var BaseUrl = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host.Value;
        //    _fileUpload.Status = true;
        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        _fileUpload.Path = BaseUrl + "/B2BAdmin/" + folderName + "/" + excelName;        //for server Web
        //    }
        //    else
        //    {
        //        _fileUpload.Path = BaseUrl + "/" + folderName + "/" + excelName;        //for Local Web
        //    }
        //    return _fileUpload;
        //    throw new NotImplementedException();
        //}



        //#endregion

        //#endregion



    }
}
