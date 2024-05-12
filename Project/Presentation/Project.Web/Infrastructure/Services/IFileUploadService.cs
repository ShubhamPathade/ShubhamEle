using Microsoft.AspNetCore.Http;
using Project.Web.Models.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Web.Infrastructure.Services
{
    public interface IFileUploadService
    {
        //Task<FileUploadStatusModel> Upload(IFormFile file, string folderName);
        //Task<FileUploadStatusModel> UploadExcel(IEnumerable<RequisitionReportExcelModel> model, string folderName);
        //Task<FileUploadStatusModel> CreateAndWriteExcel(IEnumerable<InvoiceItemUIModel> invoiceItemUIModel, InvoiceHeaderDetailUIModel invoiceHeaderDetailUIModel, string folderName);
        //Task<FileUploadStatusModel> UploadInvoice(IFormFile file, string folderName, long invoiceId);
        //Task<FileUploadStatusModel> DownloadVendorLedger(VendorLedgerHeaderDetailModel vendorLedgerHeaderDetailModel, IEnumerable<VendorLedgerOrderItemDetailModel> vendorLedgerOrderItemDetailModels, string folderName);

        //#region Download report section

        //Task<FileUploadStatusModel> DownloadPodReport(IEnumerable<DownloadPodReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadTripReport(IEnumerable<DownloadTripReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadCancelTripReport(IEnumerable<DownloadCancelTripReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadVendorLedgerTripReport(IEnumerable<DownloadVendorLedgerTripReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadB2BInvoiceTripReport(IEnumerable<DownloadB2BInvoiceTripReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadSMEInvoiceTripReport(IEnumerable<DownloadSMEInvoiceTripReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadExpenseReport(IEnumerable<DownloadExpenseReportModel> model, string folderName);

        //#endregion

        //#region Download ptl report section
        //Task<FileUploadStatusModel> DownloadPtlPodReport(IEnumerable<DownloadPtlPodReportModel> model, string folderName);
        //Task<FileUploadStatusModel> DownloadPtlVendorLedgerTripReport(IEnumerable<DownloadVendorLedgerTripReportPtlModel> model, string folderName);

        //#endregion
    }
}
