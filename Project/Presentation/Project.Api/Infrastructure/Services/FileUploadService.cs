using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Project.Core.Configuration;

namespace Project.Api.Infrastructure.Services
{
    public class FileUploadService : IFileUploadService
    {
        //#region Fields

        //private readonly IHttpService _httpService;
        //private readonly AppSettings _appSettings;
        //private readonly IWebHostEnvironment _hostingEnvironment;

        //#endregion

        //#region Constructor

        //public FileUploadService(IHttpService httpService,
        //    AppSettings appSettings,
        //    IWebHostEnvironment webHostEnvironment)
        //{
        //    _httpService = httpService;
        //    _appSettings = appSettings;
        //    _hostingEnvironment = webHostEnvironment;
        //}

        //#endregion

        //#region Methods

        //public async Task<FileUploadStatusModel> UploadImageFileAsync(string fileName, string folderName, Stream stream)
        //{
        //    if (string.IsNullOrWhiteSpace(fileName) || stream == null)
        //        throw new ArgumentNullException();

        //    var formData = new MultipartFormDataContent();

        //    using var streamContent = new StreamContent(stream);
        //    using var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
        //    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
        //    formData.Add(fileContent, "File", fileName);
        //    formData.Add(new StringContent(folderName), "FolderName");

        //    HttpResponseMessage httpResponse;

        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        httpResponse = await _httpService.PostAsync($"{_appSettings.WebBaseUrl}/api/FileUpload/GetImageResponse", formData);
        //    }
        //    else
        //    {
        //        //httpResponse = await _httpService.PostAsync("https://localhost:44391/api/FileUpload/GetImageResponse", formData);
        //        httpResponse = await _httpService.PostAsync("https://localhost:5001/api/FileUpload/GetImageResponse", formData);
        //    }

        //    var model = JsonConvert.DeserializeObject<FileUploadStatusModel>(await httpResponse.Content.ReadAsStringAsync());
        //    return model;
        //}

        //public async Task<FileUploadStatusModel> DownloadVendorLedgerAsync(VendorLedgerHeaderDetailModel vendorLedgerHeaderDetailModel, IEnumerable<VendorLedgerOrderItemDetailModel> vendorLedgerOrderItemDetailModels, string folderName)
        //{

        //    var formData = new MultipartFormDataContent();

        //    var stringContentVendorLedgerHeaderDetailModel = new StringContent(JsonConvert.SerializeObject(vendorLedgerHeaderDetailModel));
        //    var stringContentVendorLedgerOrderItemDetailModels = new StringContent(JsonConvert.SerializeObject(vendorLedgerOrderItemDetailModels));

        //    formData.Add(new StringContent(folderName), "folderName");
        //    formData.Add(stringContentVendorLedgerHeaderDetailModel, "vendorLedgerHeaderDetailModel");
        //    formData.Add(stringContentVendorLedgerOrderItemDetailModels, "vendorLedgerOrderItemDetailModels");

        //    HttpResponseMessage httpResponse;

        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        httpResponse = await _httpService.PostAsync($"{_appSettings.WebBaseUrl}/api/FileUpload/DownloadVendorLedger", formData);
        //    }
        //    else
        //    {
        //        httpResponse = await _httpService.PostAsync("https://localhost:44391/api/FileUpload/DownloadVendorLedger", formData);
        //    }

        //    var model = JsonConvert.DeserializeObject<FileUploadStatusModel>(await httpResponse.Content.ReadAsStringAsync());
        //    return model;
        //}

        //public async Task<FileUploadStatusModel> DownloadShippingLabelAsync(string orderNo, string folderName)
        //{
        //    var formData = new MultipartFormDataContent();
        //    formData.Add(new StringContent(orderNo), "orderNo");
        //    formData.Add(new StringContent(folderName), "folderName");

        //    HttpResponseMessage httpResponse;

        //    if (_hostingEnvironment.IsProduction())
        //    {
        //        httpResponse = await _httpService.PostAsync($"{_appSettings.WebBaseUrl}/api/FileUpload/DownloadShippingLabel", formData);
        //    }
        //    else
        //    {
        //        httpResponse = await _httpService.PostAsync("https://localhost:44391/api/FileUpload/DownloadShippingLabel", formData);
        //    }

        //    var model = JsonConvert.DeserializeObject<FileUploadStatusModel>(await httpResponse.Content.ReadAsStringAsync());
        //    return model;
        //}

        //#endregion
    }
}
