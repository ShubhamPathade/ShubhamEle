//using FirebaseAdmin.Messaging;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Project.Api.Infrastructure.Mapper.Extensions;
//using Project.Api.Infrastructure.Services;
//using Project.Api.Models;
//using Project.Api.Models.Aadhar;
//using Project.Api.Models.Common;
//using Project.Api.Models.Vendor;
//using Project.Core.Configuration;
//using Project.Core.Constants;
//using Project.Core.Domain.Aadhar;
//using Project.Core.Domain.Customers;
//using Project.Core.Domain.EmailTemplateModel;
//using Project.Core.Domain.Managers;
//using Project.Core.Domain.Orders;
//using Project.Core.Domain.ProcedureModels;
//using Project.Core.Domain.Vendors;
//using Project.Services.Aadhar;
//using Project.Services.AppVersions;
//using Project.Services.Managers;
//using Project.Services.Notifications;
//using Project.Services.Orders;
//using Project.Services.Procedures;
//using Project.Services.PushNotifications;
//using Project.Services.Users;
//using Project.Services.Vendors;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;
//using Twilio.TwiML.Voice;
//using Project.Services.SMSNotifications;
//using System.Security.Policy;

//namespace Project.Api.Controllers
//{
//    public class VendorController : BaseController
//    {
//        #region Fields

//        private readonly IVendorService _vendorService;
//        private readonly Services.Vendors.IVendorRouteService _vendorRouteService;
//        private readonly IVendorProfileService _vendorProfileService;
//        private readonly IOrderService _orderService;
//        private readonly IOrderCompletionService _orderCompletionService;
//        private readonly IBidService _bidService;
//        private readonly IManagerService _managerService;
//        private readonly IFileUploadService _fileUploadService;
//        private readonly IConfiguration _configuration;
//        private readonly IVendorDashboardService _vendorDashboardService;
//        private readonly IInTransitTripDetailsService _inTransitTripService;
//        private readonly IVendorCompletedTripDetailsService _completedTripService;
//        private readonly IPaymentDetailsService _paymentService;
//        private readonly ITrackingDetailsService _trackingService;
//        private readonly IVendorCompletedTripPaymentDetailsService _vendorCompletedTripPaymentDetailsService;
//        private readonly IVendorPaymentService _vendorPaymentService;
//        private readonly IPushNotificationService _pushNotificationService;
//        private readonly IPushNotificationOrderDetailsService _pushNotificationOrderDetailsService;
//        private readonly IUserService _userService;
//        private readonly INotificationService _notificationService;
//        private readonly IOrderDestinationDetailService _orderDestinationDetailService;
//        private readonly IAadharService _aadharService;
//        private readonly IVendorLedgerService _vendorLedgerService;
//        private readonly AppSettings _appSettings;
//        private readonly IVendorBannerService _vendorBannerService;
//        private readonly IAppVersionService _appVersionService;
//        private readonly IManagerNotificationService _managerNotificationService;
//        private readonly ISMSNotificationService _smsNotificationService;

//        #endregion

//        #region Constructor

//        public VendorController(IUserService userService,
//            IVendorService vendorService, 
//            INotificationService notificationService,
//            Services.Vendors.IVendorRouteService vendorRouteService,
//            IVendorProfileService vendorProfileService,
//            IFileUploadService fileUploadService,
//            IManagerService managerService,
//            IConfiguration configuration,
//            IOrderService orderService,
//            IOrderCompletionService orderCompletionService,
//            IBidService bidService,
//            IVendorDashboardService vendorDashboardService,
//            IInTransitTripDetailsService inTransitTripService,
//            IVendorCompletedTripDetailsService completedTripService,
//            IPaymentDetailsService paymentService,
//            ITrackingDetailsService trackingService,
//            IVendorCompletedTripPaymentDetailsService vendorCompletedTripPaymentDetailsService,
//            IVendorPaymentService vendorPaymentService,
//            IPushNotificationService pushNotificationService,
//            IPushNotificationOrderDetailsService pushNotificationOrderDetailsService,
//            IOrderDestinationDetailService orderDestinationDetailService,
//            IAadharService aadharService,
//            IVendorLedgerService vendorLedgerService,
//            AppSettings appSettings,
//            IVendorBannerService vendorBannerService,
//            IAppVersionService appVersionService,
//            IManagerNotificationService managerNotificationService,
//            ISMSNotificationService smsNotificationService)
//        {
//            _userService = userService;
//            _vendorService = vendorService;
//            _vendorRouteService = vendorRouteService;
//            _vendorProfileService = vendorProfileService;
//            _fileUploadService = fileUploadService;
//            _managerService = managerService;
//            _configuration = configuration;
//            _orderService = orderService;
//            _orderCompletionService = orderCompletionService;
//            _bidService = bidService;
//            _vendorDashboardService = vendorDashboardService;
//            _inTransitTripService = inTransitTripService;
//            _completedTripService = completedTripService;
//            _paymentService = paymentService;
//            _trackingService = trackingService;
//            _vendorCompletedTripPaymentDetailsService = vendorCompletedTripPaymentDetailsService;
//            _vendorPaymentService = vendorPaymentService;
//            _pushNotificationService = pushNotificationService;
//            _pushNotificationOrderDetailsService = pushNotificationOrderDetailsService;
//            _notificationService = notificationService;
//            _orderDestinationDetailService = orderDestinationDetailService;
//            _aadharService = aadharService;
//            _vendorLedgerService = vendorLedgerService;
//            _appSettings = appSettings;
//            _vendorBannerService = vendorBannerService;
//            _appVersionService = appVersionService;
//            _managerNotificationService = managerNotificationService;
//            _smsNotificationService = smsNotificationService;
//        }

//        #endregion

//        #region  Methods

//        public async Task<IActionResult> VendorList()
//        {
//            var vendors = await _vendorService.GetVendorsAsync();

//            #region mapper code 

//            var list = vendors.Select(manager => manager.ToModel<VendorModel>());

//            #endregion

//            var respone = new BaseResponse<IEnumerable<VendorModel>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }
//        public async Task<IActionResult> VendorNameList()
//        {
//            var vendors = await _vendorService.GetVendorNameList();

//            #region mapper code

//            var list = vendors.Select(vendor => vendor.ToModel<VendorNameModel>());

//            #endregion

//            var respone = new BaseResponse<IEnumerable<VendorNameModel>>()
//            {
//                Data = list,
//                Messaage = "success",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> ProfileDetaisById(int Id)
//        {
//            var vendor = await _vendorService.GetVendorAsync(Id);

//            var respone = new BaseResponse<Vendor>()
//            {
//                Data = vendor,
//                Messaage = "sucess",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> VendorListByManagerId(int managerId)
//        {
//            var vendors = await _vendorService.GetVendorsByManagerIdAsync(managerId);

//            #region mapper code 

//            var list = vendors.Select(vendor => vendor.ToModel<VendorModel>());

//            #endregion

//            var respone = new BaseResponse<IEnumerable<VendorModel>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }


//        [HttpPost]
//        public async Task<IActionResult> UpdateVendorProfileImage(VendorProfileImageModel model)
//        {
//            FileUploadStatusModel ImageResponse;
//            var vendor = await _vendorService.GetVendorByIdAsync(model.Id);
//            if (vendor != null)
//            {
//                string ImageFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                byte[] imageBytes = Convert.FromBase64String(model.ProfileImage);
//                using (MemoryStream ms = new MemoryStream(imageBytes))
//                {
//                    ImageResponse = await _fileUploadService.UploadImageFileAsync(ImageFileName, DocUploadFolderNames.VendorProfile, ms);
//                }

//                if (ImageResponse == null)
//                {
//                    vendor.ProfileImage = null;
//                }
//                else
//                {
//                    vendor.ProfileImage = ImageResponse.Status ? ImageResponse.UrlPath : string.Empty;
//                }
//                await _vendorService.UpdateVendorAsync(vendor);
//                var respone = new BaseResponse<string>()
//                {
//                    Data = vendor.ProfileImage,
//                    Messaage = "Vendor image update successfull",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor  image not update successfull",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }

//        }


//        public void LoadBase64(string base64)
//        {
//            byte[] bytes = Convert.FromBase64String(base64);
//            using (MemoryStream ms = new MemoryStream(bytes))
//            {
//                _fileUploadService.UploadImageFileAsync("Test.jpg", "CustomerPhoto", ms);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> VendorRegistration(VendorSignUpModel model)
//        {
//            var vendor = model.ToEntity<Vendor>();
//            FileUploadStatusModel adharImageResponse, panImageResponse, cancelledChequeImageResponse;

//            int countMobNo = await _vendorService.CheckMobNoAlreadyPresentOrNot(model.ContactPersonNumber);
//            int countEmail = await _vendorService.CheckEmailAlreadyPresentOrNot(model.ContactPersonEmail);

//            if (countMobNo == 0)
//            {
//                if (countEmail == 0)
//                {

//                    string adharFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                    byte[] adharBytes = Convert.FromBase64String(model.AadharImagePath);
//                    using (MemoryStream ms = new MemoryStream(adharBytes))
//                    {
//                        adharImageResponse = await _fileUploadService.UploadImageFileAsync(adharFileName, DocUploadFolderNames.VendorAdharImage, ms);
//                    }

//                    if (adharImageResponse == null)
//                    {
//                        vendor.AadharImagePath = null;
//                    }
//                    else
//                    {
//                        vendor.AadharImagePath = adharImageResponse.Status ? adharImageResponse.UrlPath : string.Empty;
//                    }

//                    string panFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                    byte[] panBytes = Convert.FromBase64String(model.AadharImagePath);
//                    using (MemoryStream ms = new MemoryStream(panBytes))
//                    {
//                        panImageResponse = await _fileUploadService.UploadImageFileAsync(panFileName, DocUploadFolderNames.VendorPanImage, ms);
//                    }

//                    if (panImageResponse == null)
//                    {
//                        vendor.PanImagePath = null;
//                    }
//                    else
//                    {
//                        vendor.PanImagePath = panImageResponse.Status ? panImageResponse.UrlPath : string.Empty;
//                    }

//                    string cancelledChequeFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                    byte[] cancelledChequeBytes = Convert.FromBase64String(model.AadharImagePath);
//                    using (MemoryStream ms = new MemoryStream(cancelledChequeBytes))
//                    {
//                        cancelledChequeImageResponse = await _fileUploadService.UploadImageFileAsync(cancelledChequeFileName, DocUploadFolderNames.VendorCancelledChequeImage, ms);
//                    }

//                    if (cancelledChequeImageResponse == null)
//                    {
//                        vendor.CancelledChequeImagePath = null;
//                    }
//                    else
//                    {
//                        vendor.CancelledChequeImagePath = cancelledChequeImageResponse.Status ? cancelledChequeImageResponse.UrlPath : string.Empty;
//                    }

//                    vendor.Status = VendorStatus.Pending;
//                    await _vendorService.InsertVendorAsync(vendor);
//                    var portal = await _userService.GetUserInfoByEmail(_appSettings.SuperAdminEmail);
//                    var portalList = new List<string>();
//                    if (portal != null)
//                    {

//                        if (!string.IsNullOrWhiteSpace(portal.DeviceToken))
//                        {
//                            portalList.Add(portal.DeviceToken);

//                            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
//                            keyValuePairs.Add("title", "Vender Approval");
//                            keyValuePairs.Add("body", "New vendor registration request received.");
//                            keyValuePairs.Add("url", $"{_appSettings.WebBaseUrl}/Vendor/Edit/" + vendor.Id);

//                            if (portalList.Count > 0)
//                                await _pushNotificationService.SendPushNotification(portalList, keyValuePairs);
//                        }

//                    }
//                    //VenderRegistrationNotificationTemplateModel vendorDetails = new VenderRegistrationNotificationTemplateModel();
//                    //var vDetails = await _vendorService.GetVendorAsync(vendor.Id);
//                    //vendorDetails.VendorCompanyName = vDetails.VendorCompanyName;
//                    //vendorDetails.AadharNumber = vDetails.AadharNumber;
//                    //vendorDetails.PanNumber = vDetails.PanNumber;
//                    //vendorDetails.OfficeAddress = vDetails.OfficeAddress;
//                    //vendorDetails.ContactPersonName = vDetails.ContactPersonName;
//                    //vendorDetails.ContactPersonNumber = vDetails.ContactPersonNumber;
//                    //vendorDetails.ContactPersonEmail = vDetails.ContactPersonEmail;
//                    //vendorDetails.BankAcNumber = vDetails.BankAcNumber;
//                    //vendorDetails.BankName = vDetails.BankName;
//                    //vendorDetails.IFSCCode = vDetails.IFSCCode;
//                    //vendorDetails.UserEmail = "shirajnadaf1996@gmail.com";
//                    //vendorDetails.UserName = "Truckbhejo";

//                    //bool a = await _notificationService.VenderRegistrationNotification(vendorDetails, "Vender.Registration.Notification");

//                    var respone = new BaseResponse<VendorSignUpModel>()
//                    {
//                        Data = null,
//                        Messaage = "Vendor Registration successfull",
//                        Status = Status.Success
//                    };
//                    return Ok(respone);
//                }
//                else
//                {
//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = null,
//                        Messaage = "Email already present",
//                        Status = Status.Email
//                    };
//                    return Ok(respone);
//                }
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = null,
//                    Messaage = "MobNo already present",
//                    Status = Status.Moboile
//                };
//                return Ok(respone);
//            }


//        }


//        [HttpPost]
//        public async Task<IActionResult> VendorRegistrationUpdate(VendorSignUpModel model)
//        {
//            FileUploadStatusModel adharImageResponse, panImageResponse, cancelledChequeImageResponse;
//            var vendor = await _vendorService.GetVendorAsync(model.Id);

//            if (vendor != null)
//            {
//                string adharFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                byte[] adharBytes = Convert.FromBase64String(model.AadharImagePath);
//                using (MemoryStream ms = new MemoryStream(adharBytes))
//                {
//                    adharImageResponse = await _fileUploadService.UploadImageFileAsync(adharFileName, DocUploadFolderNames.VendorAdharImage, ms);
//                }

//                if (adharImageResponse == null)
//                {
//                    vendor.AadharImagePath = null;
//                }
//                else
//                {
//                    vendor.AadharImagePath = adharImageResponse.Status ? adharImageResponse.UrlPath : string.Empty;
//                }

//                string panFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                byte[] panBytes = Convert.FromBase64String(model.PanImagePath);
//                using (MemoryStream ms = new MemoryStream(panBytes))
//                {
//                    panImageResponse = await _fileUploadService.UploadImageFileAsync(panFileName, DocUploadFolderNames.VendorPanImage, ms);
//                }

//                if (panImageResponse == null)
//                {
//                    vendor.PanImagePath = null;
//                }
//                else
//                {
//                    vendor.PanImagePath = panImageResponse.Status ? panImageResponse.UrlPath : string.Empty;
//                }

//                string cancelledChequeFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                byte[] cancelledChequeBytes = Convert.FromBase64String(model.CancelledChequeImagePath);
//                using (MemoryStream ms = new MemoryStream(cancelledChequeBytes))
//                {
//                    cancelledChequeImageResponse = await _fileUploadService.UploadImageFileAsync(cancelledChequeFileName, DocUploadFolderNames.VendorCancelledChequeImage, ms);
//                }

//                if (cancelledChequeImageResponse == null)
//                {
//                    vendor.CancelledChequeImagePath = null;
//                }
//                else
//                {
//                    vendor.CancelledChequeImagePath = cancelledChequeImageResponse.Status ? cancelledChequeImageResponse.UrlPath : string.Empty;
//                }

//                vendor.Status = VendorStatus.Pending;
//                vendor.CityId = model.CityId;
//                vendor.OfficeAddress = model.OfficeAddress;
//                vendor.AadharNumber = model.AadharNumber;
//                vendor.PanNumber = model.PanNumber;
//                vendor.BankName = model.BankName;
//                vendor.BankAcNumber = model.BankAcNumber;
//                vendor.IFSCCode = model.IFSCCode;
//                vendor.ReferenceNumber = model.ReferenceNumber;
//                await _vendorService.UpdateVendorAsync(vendor);
//                var portal = await _userService.GetUserInfoByEmail(_appSettings.SuperAdminEmail);
//                var portalList = new List<string>();
//                if (portal != null)
//                {
//                    if (!string.IsNullOrWhiteSpace(portal.DeviceToken))
//                    {
//                        portalList.Add(portal.DeviceToken);

//                        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
//                        keyValuePairs.Add("title", "Vender Approval");
//                        keyValuePairs.Add("body", "New vendor KYC request received.");
//                        keyValuePairs.Add("url", $"{_appSettings.WebBaseUrl}/Vendor/Edit/" + vendor.Id);

//                        if (portalList.Count > 0)
//                            await _pushNotificationService.SendPushNotification(portalList, keyValuePairs);
//                    }
//                }

//                var respone = new BaseResponse<VendorSignUpModel>()
//                {
//                    Data = null,
//                    Messaage = "Vendor KYC details updated successfull",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = null,
//                    Messaage = "Vendor not found",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> VendorCreation([FromForm] VendorRegistrationModel model)
//        {

//            #region Uploading files

//            //saving aadhar img

//            string fileName = $"{DateTime.UtcNow.ToString("yyMMDDHHmmss")}_{Path.GetExtension(model.Aadhar_Image.FileName)}";

//            var aadharImageResponse = await _fileUploadService.UploadImageFileAsync(fileName, DocUploadFolderNames.VendorAdharImage, model.Aadhar_Image.OpenReadStream());

//            //saving pan card img
//            fileName = $"{DateTime.UtcNow.ToString("yyMMDDHHmmss")}_{Path.GetExtension(model.Pan_Image.FileName)}";

//            var panImageResponse = await _fileUploadService.UploadImageFileAsync(fileName, DocUploadFolderNames.VendorPanImage,
//                model.Pan_Image.OpenReadStream());

//            //saving cheque img
//            fileName = $"{DateTime.UtcNow.ToString("yyMMDDHHmmss")}_{Path.GetExtension(model.Cheque_Image.FileName)}";

//            var chequeImageResponse = await _fileUploadService.UploadImageFileAsync(fileName, DocUploadFolderNames.VendorCancelledChequeImage, model.Cheque_Image.OpenReadStream());

//            // saving tds img
//            fileName = $"{DateTime.UtcNow.ToString("yyMMDDHHmmss")}_{Path.GetExtension(model.Tds_Image.FileName)}";
//            var tdsImageResponse = await _fileUploadService.UploadImageFileAsync(fileName, DocUploadFolderNames.VendorTdsImage, model.Tds_Image.OpenReadStream());
          
//            #endregion

//            var vendorEntity = model.ToEntity<Vendor>();

//            if (aadharImageResponse.Status)
//                vendorEntity.AadharImagePath = aadharImageResponse.UrlPath;
//            if (panImageResponse.Status)
//                vendorEntity.PanImagePath = panImageResponse.UrlPath;
//            if (chequeImageResponse.Status)
//                vendorEntity.CancelledChequeImagePath = chequeImageResponse.UrlPath;
//            if(tdsImageResponse.Status)
//                vendorEntity.TdsImagePath = tdsImageResponse.UrlPath;
//            vendorEntity.Status = VendorStatus.Pending;

//            var vendorManagerMapping = new VendorManagerMapping();

//            vendorManagerMapping.Vendor = vendorEntity;
//            //vendorManagerMapping.Vendor.User = new User()
//            //{
//            //    UserName = model.Vendor_Company_Name,
//            //    Email = model.CEmail,
//            //    MobileNo = model.CNumber
//            //};
//            vendorManagerMapping.Manager = await _managerService.GetManagerAsync(model.ManagerId);
//            vendorEntity.CreatedOn=DateTime.Now;
//            await _vendorService.InsertVendorAsync(vendorEntity);
//            await _vendorService.InsertVendorByManagerAsync(vendorManagerMapping);

//            var portal = await _userService.GetUserInfoByEmail(_appSettings.SuperAdminEmail);
//            var portalList = new List<string>();
//            if (portal != null)
//            {

//                if (!string.IsNullOrWhiteSpace(portal.DeviceToken))
//                {
//                    portalList.Add(portal.DeviceToken);

//                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
//                    keyValuePairs.Add("title", "Vender Approval");
//                    keyValuePairs.Add("body", "TruckBhejo Partner is waiting for approval. Click to see details.");
//                    keyValuePairs.Add("url", $"{_appSettings.WebBaseUrl}/Vendor/Edit/" + vendorEntity.Id);

//                    if (portalList.Count > 0)
//                        await _pushNotificationService.SendPushNotification(portalList, keyValuePairs);
//                }

//            }
//            //VenderRegistrationNotificationTemplateModel vendorDetails = new VenderRegistrationNotificationTemplateModel();
//            //var vDetails = await _vendorService.GetVendorAsync(vendorEntity.Id);
//            //vendorDetails.VendorCompanyName = vDetails.VendorCompanyName;
//            //vendorDetails.AadharNumber = vDetails.AadharNumber;
//            //vendorDetails.PanNumber = vDetails.PanNumber;
//            //vendorDetails.OfficeAddress = vDetails.OfficeAddress;
//            //vendorDetails.ContactPersonName = vDetails.ContactPersonName;
//            //vendorDetails.ContactPersonNumber = vDetails.ContactPersonNumber;
//            //vendorDetails.ContactPersonEmail = vDetails.ContactPersonEmail;
//            //vendorDetails.BankAcNumber = vDetails.BankAcNumber;
//            //vendorDetails.BankName = vDetails.BankName;
//            //vendorDetails.IFSCCode = vDetails.IFSCCode;
//            //vendorDetails.UserName = "Truckbhejo";
//            //vendorDetails.UserEmail = "rohitraigol@gmail.com";


//            //bool a = await _notificationService.VenderRegistrationNotification(vendorDetails, "Vender.Registration.Notification");


//            #region Sending sms

//            //string url = "https://www.smsgatewayhub.com/api/mt/SendSMS?APIKey=39c7dd99-18a7-493e-932f-7f8b8c5ec4b0&senderid=TBHEJO&channel=2&DCS=0&flashsms=0&number=" +
//            //    "" + vendorManagerMapping.Manager.ContactNo + "" +
//            //    "&text=Dear Mr." + vendorManagerMapping.Manager.Name + ", Your request to register " + model.Vendor_Company_Name + " as TruckBhejo Partner has been sent for approval.&route=1";
//            //     WebClient webClient = new WebClient();
//            //     webClient.DownloadString(url);


//            string text = $"\"\"\"Dear Mr. {vendorManagerMapping.Manager.Name},\r\nYour request to register {model.Vendor_Company_Name} as LoadNow Partner has been sent for approval.\"\"\r\nTeam LoadNow\"\r\n";
//            await _smsNotificationService.SendSMSWithDltAsync("LODNOW",vendorManagerMapping.Manager.ContactNo,text, "1307166306542317355");
           

//            var smsNotificationNumbers = _configuration.GetSection("VendorSMSNotificationNumbers").Get<string[]>();
//            smsNotificationNumbers[0] = "9822477676";
//            smsNotificationNumbers[1] = "9822477676";
//            if (smsNotificationNumbers != null && smsNotificationNumbers.Any())
//            {
//                foreach (var mobileNumber in smsNotificationNumbers)
//                {
//                    //       string smsUrl = "https://www.smsgatewayhub.com/api/mt/SendSMS?APIKey=39c7dd99-18a7-493e-932f-7f8b8c5ec4b0&senderid=TBHEJO&channel=2&DCS=0&flashsms=0&number=" +
//                    //"" + mobileNumber + "" +
//                    //"&text=Dear Mr." + vendorManagerMapping.Manager.Name + ", Your request to register " + model.Vendor_Company_Name + " as TruckBhejo Partner has been sent for approval.&route=1";
//                    //WebClient webc = new WebClient();
//                    //webc.DownloadString(smsUrl);
//                    text = $"\"Dear Mr. {vendorManagerMapping.Manager.Name},\r\nYour request to register {model.Vendor_Company_Name} as LoadNow Partner has been sent for approval.\"\r\nTeam LoadNow";
//                    await _smsNotificationService.SendSMSWithDltAsync("LODNOW", mobileNumber, text, "1307166306542317355");

//                }
//            }

//            #endregion

//            var respone = new BaseResponse<Vendor>()
//            {
//                Messaage = "Vender inserted sucessfully",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }


//        [HttpPost]
//        public async Task<IActionResult> VendorCreationFlutter(VendorRegistrationModel model)
//        {
//            var existMobileNo = await _vendorService.CheckMobNoAlreadyPresentOrNot(model.CNumber);
//            var existEmail = await _vendorService.CheckEmailAlreadyPresentOrNot(model.CEmail);
//            if (existMobileNo > 0)
//            {
//                var resp = new BaseResponse<string>()
//                {
//                    Data="",
//                    Messaage = "Mobile no already exist",
//                    Status = Status.Moboile
//                };
//                return Ok(resp);
//            }
//            if (existEmail > 0)
//            {
//                var resp = new BaseResponse<string>()
//                {
//                    Data="",
//                    Messaage = "Email already exist",
//                    Status = Status.Email
//                };
//                return Ok(resp);
//            }

//            FileUploadStatusModel AadharImageResponse, PanImageResponse, CancelCheckImageResponse,TdsImageResponse;
//            var vendorEntity = model.ToEntity<Vendor>();

//            #region Uploading files

//            string Extension = ".png";
//            //saving aadhar img
//            if (!string.IsNullOrWhiteSpace(model.AadharImagePath))
//            {
//                string AadharImageName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + "_" + Extension;
//                byte[] AadharBytes = Convert.FromBase64String(model.AadharImagePath);
//                using (MemoryStream ms = new MemoryStream(AadharBytes))
//                {
//                    AadharImageResponse = await _fileUploadService.UploadImageFileAsync(AadharImageName, DocUploadFolderNames.VendorAdharImage, ms);
//                }

//                if (AadharImageResponse == null)
//                {
//                    vendorEntity.AadharImagePath = null;
//                }
//                else
//                {
//                    vendorEntity.AadharImagePath = AadharImageResponse.Status ? AadharImageResponse.UrlPath : string.Empty;
//                }
//            }



//            //saving pan card img

//            if (!string.IsNullOrWhiteSpace(model.PanImagePath))
//            {
//                string PanImageName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + "_" + Extension;
//                byte[] PanBytes = Convert.FromBase64String(model.PanImagePath);
//                using (MemoryStream ms = new MemoryStream(PanBytes))
//                {
//                    PanImageResponse = await _fileUploadService.UploadImageFileAsync(PanImageName, DocUploadFolderNames.VendorPanImage, ms);
//                }

//                if (PanImageResponse == null)
//                {
//                    vendorEntity.PanImagePath = null;
//                }
//                else
//                {
//                    vendorEntity.PanImagePath = PanImageResponse.Status ? PanImageResponse.UrlPath : string.Empty;
//                }
//            }


//            //saving cheque img
//            if (!string.IsNullOrWhiteSpace(model.ChequeImagePath))
//            {
//                string ChequeImageName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + "_" + Extension;
//                byte[] ChequeBytes = Convert.FromBase64String(model.ChequeImagePath);
//                using (MemoryStream ms = new MemoryStream(ChequeBytes))
//                {
//                    CancelCheckImageResponse = await _fileUploadService.UploadImageFileAsync(ChequeImageName, DocUploadFolderNames.VendorCancelledChequeImage, ms);
//                }

//                if (CancelCheckImageResponse == null)
//                {
//                    vendorEntity.CancelledChequeImagePath = null;
//                }
//                else
//                {
//                    vendorEntity.CancelledChequeImagePath = CancelCheckImageResponse.Status ? CancelCheckImageResponse.UrlPath : string.Empty;
//                }
//            }

//            //saving tds img
//            if (!string.IsNullOrWhiteSpace(model.TdsImagePath))
//            {
//                string TdsImageName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + "_" + Extension;
//                byte[] ChequeBytes = Convert.FromBase64String(model.TdsImagePath);
//                using (MemoryStream ms = new MemoryStream(ChequeBytes))
//                {
//                    TdsImageResponse = await _fileUploadService.UploadImageFileAsync(TdsImageName, DocUploadFolderNames.VendorTdsImage, ms);
//                }

//                if (TdsImageResponse == null)
//                {
//                    vendorEntity.TdsImagePath = null;
//                }
//                else
//                {
//                    vendorEntity.TdsImagePath = TdsImageResponse.Status ? TdsImageResponse.UrlPath : string.Empty;
//                }
//            }


//            #endregion

//            vendorEntity.Status = VendorStatus.Pending;
//            vendorEntity.CreatedOn= DateTime.Now; // Addedd for manage account creation date.
//            var vendorManagerMapping = new VendorManagerMapping();

//            vendorManagerMapping.Vendor = vendorEntity;

//            vendorManagerMapping.Manager = await _managerService.GetManagerAsync(model.ManagerId);

//            await _vendorService.InsertVendorAsync(vendorEntity);
//            await _vendorService.InsertVendorByManagerAsync(vendorManagerMapping);

//            var portal = await _userService.GetUserInfoByEmail(_appSettings.SuperAdminEmail);
//            var portalList = new List<string>();
//            if (portal != null)
//            {

//                if (!string.IsNullOrWhiteSpace(portal.DeviceToken))
//                {
//                    portalList.Add(portal.DeviceToken);

//                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
//                    keyValuePairs.Add("title", "Vendor sent for approval");
//                    keyValuePairs.Add("body", "LoadNow Partner is waiting for approval. Click to see details.");
//                    keyValuePairs.Add("url", $"{_appSettings.WebBaseUrl}/Vendor/Edit/" + vendorEntity.Id);

//                    if (portalList.Count > 0)
//                        await _pushNotificationService.SendPushNotification(portalList, keyValuePairs);
//                }

//            }

//            var manager = await _managerService.GetManagerAsync(model.ManagerId);
//            if (manager != null)
//            {
//                var managerListPush = new List<string>();
//                if (!string.IsNullOrWhiteSpace(manager.DeviceToken))
//                {
//                    managerListPush.Add(manager.DeviceToken);
//                }

//                var managerNotification = new ManagerNotification()
//                {
//                    ManagerId = manager.Id,
//                    OrderNo = "",
//                    CompanyId = null,
//                    CompanyName = "",
//                    CreatedOn = DateTime.Now,
//                    Action = "4",
//                    IsActive = true,
//                    Title = "Vendor sent for approval👮🏻‍♂️",
//                    Description = $"Dear {manager.Name},\nYour request to onboard {model.Vendor_Company_Name} as LoadNow partner has been sent for approval.We will notify you once it is approved."

//                };

//                await _managerNotificationService.InsertManagerNotificationAsync(managerNotification);

//                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
//                keyValuePairs.Add("action", "4");
//                keyValuePairs.Add("type", "Order");
//                keyValuePairs.Add("orderId", "");
//                keyValuePairs.Add("companyId", "0");
//                keyValuePairs.Add("companyName", "");

//                Notification notification = new Notification();
//                notification.Title = "Vendor sent for approval👮🏻‍♂️";
//                notification.Body = $"Dear {manager.Name},\nYour request to onboard {model.Vendor_Company_Name} as LoadNow partner has been sent for approval.We will notify you once it is approved.";

//                if (managerListPush.Count > 0)
//                    await _pushNotificationService.SendPushNotificationForManager(managerListPush, keyValuePairs, notification);
//            }


//            #region Sending sms



//            #endregion

//            var respone = new BaseResponse<string>()
//            {
//                Data = "",
//                Messaage = "Vender inserted sucessfully",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorListByManagerId(long mangerId)
//        {
//            if (mangerId == 0)
//            {
//                var errorResponse = new BaseResponse<List<VendorListModel>>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorService.GetVendorsByManagerIdAsync(mangerId);

//            var vendorList = new List<VendorListModel>();

//            if (list != null)
//            {
//                vendorList.AddRange(list.Select(vendor => vendor.Vendor.ToModel<VendorListModel>()));
//            }

//            var respone = new BaseResponse<List<VendorListModel>>()
//            {
//                Data = vendorList,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        [HttpPost]
//        public async Task<IActionResult> Bidsplace(PlaceBidModel model)
//        {
//            long orderId = await _orderService.GetOrderIdByOrderNoAsync(model.OrderId);

//            long bidId = await _bidService.CheckBidPresentOrNot(orderId, model.VendorId, model.BidAmount);

//            var orderDetails = await _orderService.GetOrderAsync(orderId);

//            if (bidId == 0)
//            {
//                if (model.BidAmount < 1000)
//                {
//                    var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                    {
//                        Data = null,
//                        Messaage = "Bid amount must be greater then 1000",
//                        Status = Status.ValidationError
//                    };
//                    return Ok(errorResponse);
//                }
//                else
//                {
//                    var checkCustomerType = await _orderService.CheckOrderCustomerType(model.OrderId);
//                    if (checkCustomerType == 1) //B2B customer
//                    {
//                        Bids bid = new Bids();
//                        bid.BidAmount = model.BidAmount;
//                        bid.CreatedOn = DateTime.Now;
//                        bid.IsActive = true;
//                        bid.OrderId = orderId;
//                        bid.VendorId = model.VendorId;
//                        bid.CommissionAmount = 0;
//                        bid.BidFinalAmount = model.BidAmount;

//                        await _bidService.InsertBidsAsync(bid);

//                        var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                        {
//                            Data = null,
//                            Messaage = "Bid placed Successfully",
//                            Status = Status.Success
//                        };
//                        return Ok(errorResponse);
//                    }
//                    else //SME customer
//                    {
//                        int cAmount = 0;
//                        var cList = await _bidService.GetCommissionList();
//                        foreach (var item in cList)
//                        {
//                            if (item.Min <= model.BidAmount && item.Max >= model.BidAmount)
//                            {
//                                cAmount = item.CommissionRate;
//                            }
//                        }

//                        var commissionAmount = (model.BidAmount / 100) * cAmount;
//                        var finalBidAmount = model.BidAmount + commissionAmount;

//                        if (orderDetails != null)
//                        {
//                            if (orderDetails.IsRejectBtnClicked == true)
//                            {
//                                var orderBidMinAmount = await _bidService.GetOrderMinBidAmount(orderId);
//                                if (model.BidAmount > orderBidMinAmount)
//                                {
//                                    Bids bid = new Bids();
//                                    bid.BidAmount = model.BidAmount;
//                                    bid.CreatedOn = DateTime.Now;
//                                    bid.IsActive = true;
//                                    bid.OrderId = orderId;
//                                    bid.VendorId = model.VendorId;
//                                    bid.CommissionAmount = commissionAmount;
//                                    bid.BidFinalAmount = finalBidAmount;
//                                    bid.IsShown = false;
//                                    bid.IsNewBidAfterReject = true;
//                                    bid.IsImmediatelyAvailable = model.IsImmediatelyAvailable;

//                                    await _bidService.InsertBidsAsync(bid);
//                                }
//                                else
//                                {
//                                    Bids bid = new Bids();
//                                    bid.BidAmount = model.BidAmount;
//                                    bid.CreatedOn = DateTime.Now;
//                                    bid.IsActive = true;
//                                    bid.OrderId = orderId;
//                                    bid.VendorId = model.VendorId;
//                                    bid.CommissionAmount = commissionAmount;
//                                    bid.BidFinalAmount = finalBidAmount;
//                                    bid.IsShown = true;
//                                    bid.IsNewBidAfterReject = true;
//                                    bid.IsImmediatelyAvailable = model.IsImmediatelyAvailable;

//                                    await _bidService.InsertBidsAsync(bid);

//                                    var customerList = new List<string>();

//                                    var CustomerToken = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(orderId);
//                                    if (CustomerToken != null)
//                                    {

//                                        if (!string.IsNullOrWhiteSpace(CustomerToken.CustomerDeviceToken))
//                                        {
//                                            customerList.Add(CustomerToken.CustomerDeviceToken);

//                                            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                            keyValuePairs.Add("action", "3");                   //4 For New Bid
//                                            keyValuePairs.Add("type", "newBid");
//                                            keyValuePairs.Add("orderId", CustomerToken.OrderNo);

//                                            Notification notification = new Notification();
//                                            notification.Title = "Bids Received.🙋‍♂️";
//                                            notification.Body = $"Your order to {CustomerToken.DropPoint} has received bids. Click here to view them.";

//                                            if (customerList.Count() > 0)
//                                                await _pushNotificationService.SendPushNotificationForCustomerAndVendor(customerList, keyValuePairs, notification);
//                                        }

//                                    }
//                                }
//                            }
//                            else
//                            {
//                                Bids bid = new Bids();
//                                bid.BidAmount = model.BidAmount;
//                                bid.CreatedOn = DateTime.Now;
//                                bid.IsActive = true;
//                                bid.OrderId = orderId;
//                                bid.VendorId = model.VendorId;
//                                bid.CommissionAmount = commissionAmount;
//                                bid.BidFinalAmount = finalBidAmount;
//                                bid.IsShown = true;
//                                bid.IsNewBidAfterReject = false;
//                                bid.IsImmediatelyAvailable = model.IsImmediatelyAvailable;

//                                await _bidService.InsertBidsAsync(bid);

//                                var customerList = new List<string>();

//                                var CustomerToken = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(orderId);
//                                if (CustomerToken != null)
//                                {

//                                    if (!string.IsNullOrWhiteSpace(CustomerToken.CustomerDeviceToken))
//                                    {
//                                        customerList.Add(CustomerToken.CustomerDeviceToken);

//                                        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                        keyValuePairs.Add("action", "3");                   //4 For New Bid
//                                        keyValuePairs.Add("type", "newBid");
//                                        keyValuePairs.Add("orderId", CustomerToken.OrderNo);

//                                        Notification notification = new Notification();
//                                        notification.Title = "Bids Received.🙋‍♂️";
//                                        notification.Body = $"Your order to {CustomerToken.DropPoint} has received bids. Click here to view them.";

//                                        if (customerList.Count() > 0)
//                                            await _pushNotificationService.SendPushNotificationForCustomerAndVendor(customerList, keyValuePairs, notification);
//                                    }

//                                }

//                            }
//                        }

//                        var orderDetailsForPush = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(orderId);
//                        var bidDetails = await _bidService.GetOrderBidDetailsByOrderId(orderId);
//                        var vendorList = new List<string>();
//                        if (bidDetails != null)
//                        {
//                            if (model.BidAmount < bidDetails.BidAmount)
//                            {
//                                var vendor = await _vendorService.GetVendorByIdAsync(bidDetails.VendorId);
//                                if (vendor != null)
//                                {
//                                    if (!string.IsNullOrWhiteSpace(vendor.FcmToken))
//                                    {
//                                        vendorList.Add(vendor.FcmToken);

//                                        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                        keyValuePairs.Add("action", "2");
//                                        keyValuePairs.Add("type", "newBid");
//                                        keyValuePairs.Add("orderId", orderDetails.OrderNo);

//                                        Notification notification = new Notification();
//                                        notification.Title = "Lower Bid Alert 🛑";
//                                        notification.Body = $"Lower bid received for order {orderDetailsForPush.OrderNo} to {orderDetailsForPush.DropPoint}. Place best bid to improve chances of receiving load by clicking here.";

//                                        if (vendorList.Count() > 0)
//                                            await _pushNotificationService.SendPushNotificationForCustomerAndVendor(vendorList, keyValuePairs, notification);
//                                    }
//                                }
//                            }
//                        }

//                        var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                        {
//                            Data = null,
//                            Messaage = "Bid placed Successfully",
//                            Status = Status.Success
//                        };
//                        return Ok(errorResponse);
//                    }

//                }
//            }
//            else
//            {
//                var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                {
//                    Data = null,
//                    Messaage = "Bid already present",
//                    Status = Status.Success
//                };
//                return Ok(errorResponse);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> EditBids(PlaceBidModel model)
//        {
//            long orderId = await _orderService.GetOrderIdByOrderNoAsync(model.OrderId);
//            var orderDetails = await _orderService.GetOrderAsync(orderId);

//            Bids bid = await _bidService.GetBidsAsync(model.Id);
//            if (model.BidAmount <= bid.BidAmount)
//            {
//                var checkCustomerType = await _orderService.CheckOrderCustomerType(model.OrderId);
//                if (checkCustomerType == 1) //B2B Customer
//                {
//                    BidsLogs bidLogs = new BidsLogs();
//                    bidLogs.BidAmount = bid.BidAmount;
//                    bidLogs.CreatedOn = bid.CreatedOn;
//                    bidLogs.IsActive = true;
//                    bidLogs.OrderId = bid.OrderId;
//                    bidLogs.VendorId = bid.VendorId;
//                    bidLogs.CommissionAmount = bid.CommissionAmount;
//                    bidLogs.BidFinalAmount = bid.BidFinalAmount;

//                    await _bidService.InsertBidsLogsAsync(bidLogs);

//                    bid.BidAmount = model.BidAmount;
//                    bid.CommissionAmount = 0;
//                    bid.BidFinalAmount = model.BidAmount;
//                    bid.CreatedOn = DateTime.Now;
//                    bid.IsRejectBid = false;

//                    await _bidService.UpdateBidsAsync(bid);

//                    var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                    {
//                        Data = null,
//                        Messaage = "Bid Updated Successfully",
//                        Status = Status.Success
//                    };
//                    return Ok(errorResponse);
//                }
//                else    //SME Customer
//                {
//                    BidsLogs bidLogs = new BidsLogs();
//                    bidLogs.BidAmount = bid.BidAmount;
//                    bidLogs.CreatedOn = bid.CreatedOn;
//                    bidLogs.IsActive = true;
//                    bidLogs.OrderId = bid.OrderId;
//                    bidLogs.VendorId = bid.VendorId;
//                    bidLogs.CommissionAmount = bid.CommissionAmount;
//                    bidLogs.BidFinalAmount = bid.BidFinalAmount;

//                    await _bidService.InsertBidsLogsAsync(bidLogs);

//                    int cAmount = 0;
//                    var cList = await _bidService.GetCommissionList();
//                    foreach (var item in cList)
//                    {
//                        if (item.Min <= model.BidAmount && item.Max >= model.BidAmount)
//                        {
//                            cAmount = item.CommissionRate;
//                        }
//                    }

//                    var commissionAmount = (model.BidAmount / 100) * cAmount;
//                    var finalBidAmount = model.BidAmount + commissionAmount;

//                    bid.BidAmount = model.BidAmount;
//                    bid.CommissionAmount = commissionAmount;
//                    bid.BidFinalAmount = finalBidAmount;
//                    bid.CreatedOn = DateTime.Now;
//                    bid.IsImmediatelyAvailable = model.IsImmediatelyAvailable;


//                    if (orderDetails != null)
//                    {
//                        if (orderDetails.IsRejectBtnClicked)
//                        {
//                            var orderBidMinAmount = await _bidService.GetOrderMinBidAmount(orderId);
//                            if (model.BidAmount > orderBidMinAmount)
//                            {
//                                if (bid.IsRejectBid == true)
//                                {
//                                    bid.IsShown = false;
//                                    bid.IsNewBidAfterReject = true;
//                                    bid.IsRejectBid = true;
//                                }
//                                else
//                                {
//                                    bid.IsShown = true;
//                                    bid.IsNewBidAfterReject = false;
//                                    bid.IsRejectBid = false;
//                                }
//                            }
//                            else
//                            {
//                                bid.IsShown = true;
//                                bid.IsNewBidAfterReject = true;
//                                bid.IsRejectBid = false;

//                                var customerList = new List<string>();
//                                var CustomerToken = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(bid.OrderId);
//                                if (CustomerToken != null)
//                                {

//                                    if (!string.IsNullOrWhiteSpace(CustomerToken.CustomerDeviceToken))
//                                    {
//                                        customerList.Add(CustomerToken.CustomerDeviceToken);

//                                        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                        keyValuePairs.Add("action", "3");                   //3 For New Bid
//                                        keyValuePairs.Add("type", "newBid");
//                                        keyValuePairs.Add("orderId", CustomerToken.OrderNo);

//                                        Notification notification = new Notification();
//                                        notification.Title = "Bid Alert ❗";
//                                        notification.Body = "Bid Received for your order." + CustomerToken.OrderNo + " of " + bid.BidFinalAmount;

//                                        if (customerList.Count() > 0)
//                                            await _pushNotificationService.SendPushNotificationForCustomerAndVendor(customerList, keyValuePairs, notification);
//                                    }

//                                }
//                            }
//                        }
//                        else
//                        {
//                            bid.IsShown = true;
//                            bid.IsNewBidAfterReject = false;
//                            bid.IsRejectBid = false;

//                            var customerList = new List<string>();
//                            var CustomerToken = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(bid.OrderId);
//                            if (CustomerToken != null)
//                            {

//                                if (!string.IsNullOrWhiteSpace(CustomerToken.CustomerDeviceToken))
//                                {
//                                    customerList.Add(CustomerToken.CustomerDeviceToken);

//                                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                    keyValuePairs.Add("action", "3");                   //3 For New Bid
//                                    keyValuePairs.Add("type", "newBid");
//                                    keyValuePairs.Add("orderId", CustomerToken.OrderNo);

//                                    Notification notification = new Notification();
//                                    notification.Title = "Bid Alert ❗";
//                                    notification.Body = "Bid Received for your order." + CustomerToken.OrderNo + " of " + bid.BidFinalAmount;

//                                    if (customerList.Count() > 0)
//                                        await _pushNotificationService.SendPushNotificationForCustomerAndVendor(customerList, keyValuePairs, notification);
//                                }
//                            }

//                        }
//                    }

//                    await _bidService.UpdateBidsAsync(bid);
//                    var orderDetailsForPush = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(orderId);
//                    var bidDetails = await _bidService.GetOrderBidDetailsByOrderId(orderId);
//                    var vendorList = new List<string>();
//                    if (bidDetails != null)
//                    {
//                        if (model.BidAmount < bidDetails.BidAmount)
//                        {
//                            var vendor = await _vendorService.GetVendorByIdAsync(bidDetails.VendorId);
//                            if (vendor != null)
//                            {
//                                if (!string.IsNullOrWhiteSpace(vendor.FcmToken))
//                                {
//                                    vendorList.Add(vendor.FcmToken);

//                                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                                    keyValuePairs.Add("action", "2");
//                                    keyValuePairs.Add("type", "newBid");
//                                    keyValuePairs.Add("orderId", orderDetails.OrderNo);

//                                    Notification notification = new Notification();
//                                    notification.Title = "Lower Bid Alert 🛑";
//                                    notification.Body = $"Lower bid received for order {orderDetailsForPush.OrderNo} to {orderDetailsForPush.DropPoint}. Place best bid to improve chances of receiving load by clicking here.";

//                                    if (vendorList.Count() > 0)
//                                        await _pushNotificationService.SendPushNotificationForCustomerAndVendor(vendorList, keyValuePairs, notification);
//                                }
//                            }
//                        }
//                    }

//                    var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                    {
//                        Data = null,
//                        Messaage = "Bid Updated Successfully",
//                        Status = Status.Success
//                    };
//                    return Ok(errorResponse);
//                }

//            }
//            else
//            {
//                var errorResponse = new BaseResponse<List<PlaceBidModel>>()
//                {
//                    Data = null,
//                    Messaage = "Bid amount should be less than previous bid amount",
//                    Status = Status.ValidationError
//                };
//                return Ok(errorResponse);
//            }

//        }

//        [HttpPost]
//        public async Task<IActionResult> VendorEPODUpload(VendorUploadEPODModel model)
//        {
//            model.OrderId = await _orderService.GetOrderIdByOrderNoAsync(model.OrderNo);

//            OrderCompletion ordercompletion = await _orderCompletionService.GetOrderCompletionsAsyncByOrderId(model.OrderId);

//            FileUploadStatusModel podImgFrontPathResponse, podImgBackPathResponse;

//            string Extension = ".png";
//            if (string.IsNullOrWhiteSpace(model.PODImgBackPath))
//            {
//                Extension = ".pdf";
//            }
//            else
//            {
//                Extension = ".png";
//            }

//            string podImgFrontFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + Extension;
//            byte[] podImgFrontBytes = Convert.FromBase64String(model.PODImgFrontPath);
//            using (MemoryStream ms = new MemoryStream(podImgFrontBytes))
//            {
//                podImgFrontPathResponse = await _fileUploadService.UploadImageFileAsync(podImgFrontFileName, DocUploadFolderNames.PODImgFrontImage, ms);
//            }

//            if (podImgFrontPathResponse == null)
//            {
//                ordercompletion.PODImgFrontPath = null;
//            }
//            else
//            {
//                ordercompletion.PODImgFrontPath = podImgFrontPathResponse.Status ? podImgFrontPathResponse.UrlPath : string.Empty;
//            }

//            if (!string.IsNullOrWhiteSpace(model.PODImgBackPath))
//            {
//                string podImgBackFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}" + Extension;
//                byte[] panBytes = Convert.FromBase64String(model.PODImgBackPath);
//                using (MemoryStream ms = new MemoryStream(panBytes))
//                {
//                    podImgBackPathResponse = await _fileUploadService.UploadImageFileAsync(podImgBackFileName, DocUploadFolderNames.VendorPanImage, ms);
//                }

//                if (podImgBackPathResponse == null)
//                {
//                    ordercompletion.PODImgBackPath = null;
//                }
//                else
//                {
//                    ordercompletion.PODImgBackPath = podImgBackPathResponse.Status ? podImgBackPathResponse.UrlPath : string.Empty;
//                }
//            }

//            ordercompletion.PODStatus = true;         // Deliver with POD
//            ordercompletion.AcceptanceStatus = PODAcceptanceStatus.Pending;
//            ordercompletion.CreatedOn = DateTime.Now;
//            await _orderCompletionService.UpdateOrderCompletionAsync(ordercompletion);

//            var customerList = new List<string>();
//            var orderDetails = await _pushNotificationOrderDetailsService.GetPushNotificationOrderDetails(model.OrderId);

//            if (orderDetails != null)
//            {
//                if (!string.IsNullOrWhiteSpace(orderDetails.CustomerDeviceToken))
//                {
//                    customerList.Add(orderDetails.CustomerDeviceToken);

//                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                    keyValuePairs.Add("action", "4");
//                    keyValuePairs.Add("type", "newLoad");
//                    keyValuePairs.Add("orderId", orderDetails.OrderNo);

//                    Notification notification = new Notification();
//                    notification.Title = "POD for " + orderDetails.OrderNo + " uploaded successfully.";
//                    notification.Body = "POD for " + orderDetails.OrderNo + " uploaded successfully.";

//                    if (customerList.Count() > 0)
//                        await _pushNotificationService.SendPushNotificationForCustomerAndVendor(customerList, keyValuePairs, notification);
//                }
//            }
//            //PodSubmissionNotificationTemplate podDetails = new PodSubmissionNotificationTemplate();
//            //podDetails.OrderNo = orderDetails.OrderNo;
//            //podDetails.TruckNumber = orderDetails.TruckNumber;
//            //podDetails.CompanyName = orderDetails.CompanyName;
//            //podDetails.PickupPoint = orderDetails.TruckNumber;
//            //podDetails.LRNumber = orderDetails.LRNumber;
//            //podDetails.DropPoint = orderDetails.DropPoint;
//            //podDetails.UserEmail = "rohitraigol@gmail.com";
//            //podDetails.UserName = "Truckbhejo";

//            //bool a = await _notificationService.PodSubmissionNotification(podDetails, "Vender.POD.Notification");

//            var respone = new BaseResponse<VendorSignUpModel>()
//            {
//                Data = null,
//                Messaage = "Vendor EPOD  upload successfully",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }

//        [HttpPost]
//        public async Task<IActionResult> VendorPhysicalPODUpload(VendorUploadPhysicalPODModel model)
//        {
//            model.OrderId = await _orderService.GetOrderIdByOrderNoAsync(model.OrderNo);

//            OrderCompletion ordercompletion = await _orderCompletionService.GetOrderCompletionsAsyncByOrderId(model.OrderId);

//            FileUploadStatusModel receiptImgPathResponse;

//            string receiptImgFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//            byte[] receiptImgBytes = Convert.FromBase64String(model.ReceiptImgPath);
//            using (MemoryStream ms = new MemoryStream(receiptImgBytes))
//            {
//                receiptImgPathResponse = await _fileUploadService.UploadImageFileAsync(receiptImgFileName, DocUploadFolderNames.ReceiptImage, ms);
//            }

//            if (receiptImgPathResponse == null)
//            {
//                ordercompletion.ReceiptImgPath = null;
//            }
//            else
//            {
//                ordercompletion.ReceiptImgPath = receiptImgPathResponse.Status ? receiptImgPathResponse.UrlPath : string.Empty;
//            }

//            ordercompletion.PODPhysicalAcceptanceStatusId = PhysicalPODAcceptanceStatus.Pending;
//            ordercompletion.DispatchDate = model.DispatchDate;
//            ordercompletion.TrackingNo = model.TrackingNo;
//            ordercompletion.CreatedOn = DateTime.Now;
//            await _orderCompletionService.UpdateOrderCompletionAsync(ordercompletion);

//            var respone = new BaseResponse<VendorSignUpModel>()
//            {
//                Data = null,
//                Messaage = "Vendor Physical POD  upload successfully",
//                Status = Status.Success
//            };
//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorProfile(long vendorId)
//        {
//            if (vendorId == 0)
//            {
//                var errorResponse = new BaseResponse<List<VendorProfileModel>>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorProfileService.VendorProfileDetail(vendorId);

//            var respone = new BaseResponse<IEnumerable<VendorProfileModel>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }
//        [HttpGet]
//        public async Task<IActionResult> GetVendorDetails(long vendorId)
//        {
//            if (vendorId == 0)
//            {
//                var errorResponse = new BaseResponse<List<VendorProfile>>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorProfileService.VendorProfile(vendorId);

//            var respone = new BaseResponse<IEnumerable<VendorProfile>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorDetailsForCustomer(long vendorId)
//        {
//            if (vendorId == 0)
//            {
//                var errorResponse = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorProfileService.GetVendorProfileForCustomer(vendorId);

//            var respone = new BaseResponse<VendorProfileForCustomerModel>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorDashboard(long vendorId)
//        {
//            if (vendorId == 0)
//            {
//                var errorResponse = new BaseResponse<List<VendorDashboardModel>>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorDashboardService.VendorDashboardDetail(vendorId);

//            var respone = new BaseResponse<IEnumerable<VendorDashboardModel>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetRoutes(long vendorId)
//        {

//            var vendorRoute = await _vendorRouteService.GetVendorRoutesByVendorIdAsync(vendorId);

//            var errorResponse = new BaseResponse<IEnumerable<VendorRoute>>()
//            {
//                Data = vendorRoute,
//                Messaage = "Vendor routes Get Successfully",
//                Status = Status.Success
//            };
//            return Ok(errorResponse);
//        }

//        [HttpPost]
//        public async Task<IActionResult> AddRoutes(VendorRouteModel model)
//        {
//            var route = model.ToEntity<VendorRoute>();
//            route.IsActive = true;
//            route.CreatedOn = DateTime.Now;

//            await _vendorRouteService.InsertVendorRouteAsync(route);

//            var errorResponse = new BaseResponse<string>()
//            {
//                Data = null,
//                Messaage = "Vendor route saved Successfully",
//                Status = Status.Success
//            };
//            return Ok(errorResponse);
//        }

//        [HttpPost]
//        public async Task<IActionResult> DeleteRoutes(long routeId)
//        {

//            var route = await _vendorRouteService.GetVendorRouteAsync(routeId);
//            route.IsActive = false;
//            route.ModifiedOn = DateTime.Now;

//            await _vendorRouteService.UpdateVendorRouteAsync(route);

//            var errorResponse = new BaseResponse<string>()
//            {
//                Data = null,
//                Messaage = "Vendor route deleted Successfully",
//                Status = Status.Success
//            };
//            return Ok(errorResponse);
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetIntransitTripDetails(long vendorId, string OrderNo)
//        {
//            var inTransitTrip = await _inTransitTripService.InTransitTripDetail(vendorId, OrderNo);
//            var payment = await _paymentService.PaymentDetail(vendorId, OrderNo);
//            var tracking = await _trackingService.TrackingDetail(OrderNo);

//            InTransitSuperModel superModel = new InTransitSuperModel();

//            if (inTransitTrip.Count() > 0)
//            {

//                superModel.OrderNo = inTransitTrip.FirstOrDefault().OrderNo;
//                superModel.CustomerName = inTransitTrip.FirstOrDefault().CustomerName;
//                superModel.CustomerContactNo = inTransitTrip.FirstOrDefault().CustomerContactNo;
//                superModel.FullAddressForPickup = inTransitTrip.FirstOrDefault().FullAddressForPickup;
//                superModel.FullAddressForDropLocation = inTransitTrip.FirstOrDefault().FullAddressForDropLocation;
//                superModel.FullAddressForDropLocation2 = inTransitTrip.FirstOrDefault().FullAddressForDropLocation2;
//                superModel.FullAddressForDropLocation3 = inTransitTrip.FirstOrDefault().FullAddressForDropLocation3;
//                superModel.VehicleNo = inTransitTrip.FirstOrDefault().VehicleNo;
//                superModel.DriverMobno = inTransitTrip.FirstOrDefault().DriverMobno;
//                superModel.PickupPoint = inTransitTrip.FirstOrDefault().PickupPoint;
//                superModel.DropPoint1 = inTransitTrip.FirstOrDefault().DropPoint1;
//                superModel.DropPoint2 = inTransitTrip.FirstOrDefault().DropPoint2;
//                superModel.DropPoint3 = inTransitTrip.FirstOrDefault().DropPoint3;
//                superModel.VehicleType = inTransitTrip.FirstOrDefault().VehicleType;
//                superModel.LRNo = inTransitTrip.FirstOrDefault().LRNo;
//                superModel.ToLat1 = inTransitTrip.FirstOrDefault().ToLat1;
//                superModel.ToLat2 = inTransitTrip.FirstOrDefault().ToLat2;
//                superModel.ToLat3 = inTransitTrip.FirstOrDefault().ToLat3;
//                superModel.ToLong1 = inTransitTrip.FirstOrDefault().ToLong1;
//                superModel.ToLong2 = inTransitTrip.FirstOrDefault().ToLong2;
//                superModel.ToLong3 = inTransitTrip.FirstOrDefault().ToLong3;
//                superModel.IsTrackingAllowed = inTransitTrip.FirstOrDefault().IsTrackingAllowed;
//                superModel.ProductTypeName = inTransitTrip.FirstOrDefault().ProductTypeName;
//                superModel.OrderDateTime = inTransitTrip.FirstOrDefault().OrderDateTime;
//                superModel.ISMultidrop = inTransitTrip.FirstOrDefault().ISMultidrop;
//                superModel.AdvancePaymentAmount = inTransitTrip.FirstOrDefault().AdvancePaymentAmount;
//                superModel.TransactionNumber = inTransitTrip.FirstOrDefault().TransactionNumber;
//                superModel.TripAmount = inTransitTrip.FirstOrDefault().TripAmount;
//                superModel.IsBalenceAmountInCash = inTransitTrip.FirstOrDefault().IsBalenceAmountInCash;
//                superModel.IsBalenceAmountAcceptedByVendor = inTransitTrip.FirstOrDefault().IsBalenceAmountAcceptedByVendor;
//            }
//            superModel.PaymentDetails = payment.FirstOrDefault();
//            superModel.TrackingDetails = tracking;

//            var errorResponse = new BaseResponse<InTransitSuperModel>()
//            {
//                Data = superModel,
//                Messaage = "Intransit Trip Details Get Successfully",
//                Status = Status.Success
//            };
//            return Ok(errorResponse);
//        }


//        [HttpGet]
//        public async Task<IActionResult> GetCompletedTripDetails(long vendorId, string OrderNo)
//        {
//            var ComletedTrip = await _completedTripService.CompletedTripDetail(vendorId, OrderNo);
//            var payment = await _vendorCompletedTripPaymentDetailsService.PaymentDetail(vendorId, OrderNo);

//            CompletedVendorTripsSuperModel superModel = new CompletedVendorTripsSuperModel();

//            if (ComletedTrip.Count() > 0)
//            {
//                superModel.OrderNo = ComletedTrip.FirstOrDefault().OrderNo;
//                superModel.VehicleNo = ComletedTrip.FirstOrDefault().VehicleNo;
//                superModel.DriverMobno = ComletedTrip.FirstOrDefault().DriverMobno;
//                superModel.FullAddressForPickup = ComletedTrip.FirstOrDefault().FullAddressForPickup;
//                superModel.FullAddressForDropLocation = ComletedTrip.FirstOrDefault().FullAddressForDropLocation;
//                superModel.FullAddressForDropLocation2 = ComletedTrip.FirstOrDefault().FullAddressForDropLocation2;
//                superModel.FullAddressForDropLocation3 = ComletedTrip.FirstOrDefault().FullAddressForDropLocation3;
//                superModel.PickupPoint = ComletedTrip.FirstOrDefault().PickupPoint;
//                superModel.DropPoint1 = ComletedTrip.FirstOrDefault().DropPoint1;
//                superModel.DropPoint2 = ComletedTrip.FirstOrDefault().DropPoint2;
//                superModel.DropPoint3 = ComletedTrip.FirstOrDefault().DropPoint3;
//                superModel.VehicleType = ComletedTrip.FirstOrDefault().VehicleType;
//                superModel.LRNo = ComletedTrip.FirstOrDefault().LRNo;
//                superModel.ToLat1 = ComletedTrip.FirstOrDefault().ToLat1;
//                superModel.ToLat2 = ComletedTrip.FirstOrDefault().ToLat2;
//                superModel.ToLat3 = ComletedTrip.FirstOrDefault().ToLat3;
//                superModel.ToLong1 = ComletedTrip.FirstOrDefault().ToLong1;
//                superModel.ToLong2 = ComletedTrip.FirstOrDefault().ToLong2;
//                superModel.ToLong3 = ComletedTrip.FirstOrDefault().ToLong3;
//                superModel.ISEPODUploaded = ComletedTrip.FirstOrDefault().ISEPODUploaded;
//                superModel.ISPhysicalPODUploaded = ComletedTrip.FirstOrDefault().ISPhysicalPODUploaded;
//                superModel.ISMultidrop = ComletedTrip.FirstOrDefault().ISMultidrop;
//                superModel.AdvancePaymentAmount = ComletedTrip.FirstOrDefault().AdvancePaymentAmount;
//                superModel.TransactionNumber = ComletedTrip.FirstOrDefault().TransactionNumber;
//            }
//            superModel.VendorCompletedTripPaymentDetails = payment.FirstOrDefault();

//            var errorResponse = new BaseResponse<CompletedVendorTripsSuperModel>()
//            {
//                Data = superModel,
//                Messaage = "Completed Trip Details Get Successfully",
//                Status = Status.Success
//            };
//            return Ok(errorResponse);
        
//        }

//        // Old Payment Details Method

//        [HttpGet]
//        public async Task<IActionResult> GetVendorPaymentDetails(long vendorId)
//        {
//            if (vendorId == 0)
//            {
//                var errorResponse = new BaseResponse<List<VendorPaymentsModel>>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorPaymentService.VendorPaymentDetail(vendorId);

//            var respone = new BaseResponse<IEnumerable<VendorPaymentsModel>>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        //New Payment Details Method

//       //[HttpGet]
//       //public async Task<IActionResult> GetVendorPaymentDetails(long vendorId)
//       //{
//       //    if (vendorId == 0)
//       //    {
//       //        var errorResponse = new BaseResponse<List<VendorPaymentsModel>>()
//       //        {
//       //            Messaage = "failure",
//       //            Status = Status.Fail
//       //        };
//       //        return Ok(errorResponse);
//       //    }

//       //    var list = await _vendorPaymentService.VendorPaymentDetail(vendorId);

//       //    var respone = new BaseResponse<VendorPaymentsModel>()
//       //    {
//       //        Data = list,
//       //        Messaage = "sucess",
//       //        Status = Status.Success
//       //    };

//       //    return Ok(respone);
//       //}

//       [HttpGet]
//        public async Task<IActionResult> GetVendorOrderDocumentDetails(long vendorId, string orderNo)
//        {
//            if (vendorId == 0 && orderNo == null)
//            {
//                var errorResponse = new BaseResponse<VendorOrderDocumentModel>()
//                {
//                    Messaage = "failure",
//                    Status = Status.Fail
//                };
//                return Ok(errorResponse);
//            }

//            var list = await _vendorPaymentService.GetVendorOrderDocument(vendorId, orderNo);

//            var respone = new BaseResponse<VendorOrderDocumentModel>()
//            {
//                Data = list,
//                Messaage = "sucess",
//                Status = Status.Success
//            };

//            return Ok(respone);
//        }

//        [HttpGet]
//        public async Task<ActionResult> Email(long id)
//        {
//            VenderRegistrationNotificationTemplateModel vendorDetails = new VenderRegistrationNotificationTemplateModel();
//            var vDetails = await _vendorService.GetVendorAsync(id);
//            vendorDetails.VendorCompanyName = vDetails.VendorCompanyName;
//            vendorDetails.AadharNumber = vDetails.AadharNumber;
//            vendorDetails.PanNumber = vDetails.PanNumber;
//            vendorDetails.OfficeAddress = vDetails.OfficeAddress;
//            vendorDetails.ContactPersonName = vDetails.ContactPersonName;
//            vendorDetails.ContactPersonNumber = vDetails.ContactPersonNumber;
//            vendorDetails.ContactPersonEmail = vDetails.ContactPersonEmail;
//            vendorDetails.BankAcNumber = vDetails.BankAcNumber;
//            vendorDetails.BankName = vDetails.BankName;
//            vendorDetails.IFSCCode = vDetails.IFSCCode;
//            vendorDetails.UserName = "Truckbhejo";
//            vendorDetails.UserEmail = _appSettings.TruckBhejoEmail;


//            await _notificationService.VenderRegistrationNotification(vendorDetails, "Vender.Registration.Notification");

//            var respone = new BaseResponse<VendorSignUpModel>()
//            {
//                Data = null,
//                Messaage = "Vendor Registration successfull",
//                Status = Status.Success
//            };
//            return Ok(respone);

//        }

//        [HttpPost]
//        public async Task<IActionResult> UpdateVendorBasicDetails(VendorSignUpModel vendor)
//        {
//            var ven = await _vendorService.GetVendorAsync(vendor.Id);
//            if (ven != null)
//            {
//                var vendorEmail = await _vendorService.CheckEmailAlreadyPresentOrNot(vendor.ContactPersonEmail);
//                if (vendorEmail == 0)
//                {
//                    ven.VendorCompanyName = vendor.VendorCompanyName;
//                    ven.ContactPersonEmail = vendor.ContactPersonEmail;
//                    ven.ContactPersonName = vendor.ContactPersonName;

//                    await _vendorService.UpdateVendorAsync(ven);

//                    VendorBasicDetailsModel vendorBasicDetailsModel = new VendorBasicDetailsModel();
//                    vendorBasicDetailsModel.Id = ven.Id;
//                    vendorBasicDetailsModel.ApiToken = ven.APIToken;
//                    vendorBasicDetailsModel.VendorCompanyName = ven.VendorCompanyName;
//                    vendorBasicDetailsModel.ContactPersonEmail = ven.ContactPersonEmail;
//                    vendorBasicDetailsModel.ContactPersonName = ven.ContactPersonName;
//                    vendorBasicDetailsModel.ContactPersonNumber = ven.ContactPersonNumber;

//                    #region Email Service dt 28-05-2022 by SN

//                    VenderRegistrationNotificationTemplateModel vendorDetails = new VenderRegistrationNotificationTemplateModel();
//                    vendorDetails.VendorCompanyName = vendor.VendorCompanyName;
//                    vendorDetails.AadharNumber = "";
//                    vendorDetails.PanNumber = "";
//                    vendorDetails.OfficeAddress = "";
//                    vendorDetails.ContactPersonName = vendor.ContactPersonName;
//                    vendorDetails.ContactPersonNumber = ven.ContactPersonNumber;
//                    vendorDetails.ContactPersonEmail = vendor.ContactPersonEmail;
//                    vendorDetails.BankAcNumber = "";
//                    vendorDetails.BankName = "";
//                    vendorDetails.IFSCCode = "";
//                    vendorDetails.UserEmail = _appSettings.TruckBhejoEmail;
//                    vendorDetails.UserName = "Truckbhejo";

//                    await _notificationService.VenderRegistrationNotification(vendorDetails, "Vender.Registration.Notification");

//                    #endregion

//                    var respone = new BaseResponse<VendorBasicDetailsModel>()
//                    {
//                        Data = vendorBasicDetailsModel,
//                        Messaage = "success",
//                        Status = Status.Success
//                    };
//                    return Ok(respone);
//                }
//                else
//                {
//                    VendorBasicDetailsModel venDeatils = new VendorBasicDetailsModel();
//                    var respone = new BaseResponse<VendorBasicDetailsModel>()
//                    {
//                        Data = venDeatils,
//                        Messaage = "Email already exist",
//                        Status = Status.Email
//                    };
//                    return Ok(respone);
//                }
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Failure",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> VerifyAadhar(VerifyAadharModel verifyAadhar)
//        {
//            var vendor = await _vendorService.GetVendorAsync(verifyAadhar.VendorId);
//            if (vendor != null)
//            {
//                vendor.AadharNumber = verifyAadhar.AadharNumber;
//                vendor.Status = VendorStatus.ApprovedActive;

//                await _vendorService.UpdateVendorAsync(vendor);

//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "success",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Failure",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> UpdateBankDetails(VendorBankDetailsModel model)
//        {
//            FileUploadStatusModel cancelledChequeImageResponse;
//            var vendor = await _vendorService.GetVendorAsync(model.VendorId);

//            if (vendor != null)
//            {

//                string cancelledChequeFileName = $"IMG_{DateTime.UtcNow.ToString("yyMMDDHHmmss")}.png";
//                byte[] cancelledChequeBytes = Convert.FromBase64String(model.CancelledChequeImagePath);
//                using (MemoryStream ms = new MemoryStream(cancelledChequeBytes))
//                {
//                    cancelledChequeImageResponse = await _fileUploadService.UploadImageFileAsync(cancelledChequeFileName, DocUploadFolderNames.VendorCancelledChequeImage, ms);
//                }

//                if (cancelledChequeImageResponse == null)
//                {
//                    vendor.CancelledChequeImagePath = null;
//                }
//                else
//                {
//                    vendor.CancelledChequeImagePath = cancelledChequeImageResponse.Status ? cancelledChequeImageResponse.UrlPath : string.Empty;
//                }

//                vendor.PanNumber = model.PanNumber;
//                vendor.BankName = model.BankName;
//                vendor.BankAcNumber = model.BankAcNumber;
//                vendor.IFSCCode = model.IFSCCode;
//                await _vendorService.UpdateVendorAsync(vendor);

//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor bank details updated successfull",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor not found",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        public async Task<IActionResult> CheckAdhaarExistOrNot(string adhaarNo)
//        {

//            var vendor = await _vendorService.CheckAdhaarExistOrNotAsync(adhaarNo);

//            if (vendor != null)
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor adhaar no is already exist",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor adhaar no is not exist",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorOrderDetails(long vendorId, string orderNo)
//        {

//            if (vendorId != 0 && !string.IsNullOrWhiteSpace(orderNo))
//            {
//                var orderDetails = await _completedTripService.VendorOrderDetails(vendorId, orderNo);

//                var respone = new BaseResponse<VendorOrderDetailsModel>()
//                {
//                    Data = orderDetails,
//                    Messaage = "Success",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<VendorOrderDetailsModel>()
//                {
//                    Messaage = "Failure",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> AadharGenarateOtp(AadharModel aadharModel)
//        {

//            var vendor = await _vendorService.CheckAdhaarExistOrNotAsync(aadharModel.AadharNumber);

//            if (vendor != null)
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Vendor adhaar no is already exist",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var aadharGenarateOtpModel = new AadharGenarateOtpModel()
//                {
//                    id_number = aadharModel.AadharNumber
//                };

//                var aadhar = await _aadharService.AadharGenerateOtp(aadharGenarateOtpModel);

//                if (aadhar != null && aadhar.Success == true)
//                {
//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = aadhar.Data.ClientId,
//                        Messaage = aadhar.Message,
//                        Status = Status.Success
//                    };
//                    return Ok(respone);
//                }
//                else
//                {
//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = "",
//                        Messaage = aadhar.Message,
//                        Status = Status.Fail
//                    };
//                    return Ok(respone);
//                }

//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> AadharSubmitOtp(AadharModel aadharModel)
//        {

//            if (aadharModel == null)
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Aadhar not verified!",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var aadharSubmitOtpModel = new AadharSubmitOtpModel()
//                {
//                    client_id = aadharModel.ClientId,
//                    otp = aadharModel.Otp
//                };

//                var aadhar = await _aadharService.AadharSubmitOtp(aadharSubmitOtpModel);

//                if (aadhar != null && aadhar.Success == true)
//                {
//                    var vendor = await _vendorService.GetVendorAsync(aadharModel.VendorId);
//                    if (vendor != null)
//                    {
//                        vendor.AadharNumber = aadhar.Data.AadharNumber;
//                        vendor.Status = VendorStatus.ApprovedActive;

//                        await _vendorService.UpdateVendorAsync(vendor);

//                        var vendorDetails = await _vendorService.GetVendorAsync(vendor.Id);
//                        var vendorList = new List<string>();
//                        if (vendorDetails != null && !string.IsNullOrWhiteSpace(vendorDetails.FcmToken))
//                        {
//                            vendorList.Add(vendorDetails.FcmToken);

//                            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

//                            keyValuePairs.Add("action", "7");                   //1 For Dashboard 
//                            keyValuePairs.Add("type", "newLoad");
//                            keyValuePairs.Add("orderId", "");

//                            Notification notification = new Notification();
//                            notification.Title = "Registration Complete.✅";
//                            notification.Body = $"Dear {vendorDetails.VendorCompanyName}, your account is now verified on LoadNow.";

//                            if (vendorList.Count() > 0)
//                                await _pushNotificationService.SendPushNotificationForCustomerAndVendor(vendorList, keyValuePairs, notification);
//                        }

//                        #region Email Service dt 02-06-2022 by MK

//                        VenderRegistrationNotificationTemplateModel vendorDetailsForMail = new VenderRegistrationNotificationTemplateModel();
//                        vendorDetailsForMail.VendorCompanyName = vendor.VendorCompanyName;
//                        vendorDetailsForMail.AadharNumber = vendor.AadharNumber;
//                        vendorDetailsForMail.PanNumber = vendor.PanNumber ?? "";
//                        vendorDetailsForMail.OfficeAddress = vendor.OfficeAddress ?? "";
//                        vendorDetailsForMail.ContactPersonName = vendor.ContactPersonName;
//                        vendorDetailsForMail.ContactPersonNumber = vendor.ContactPersonNumber;
//                        vendorDetailsForMail.ContactPersonEmail = vendor.ContactPersonEmail;
//                        vendorDetailsForMail.BankAcNumber = vendor.BankAcNumber ?? "";
//                        vendorDetailsForMail.BankName = vendor.BankName ?? "";
//                        vendorDetailsForMail.IFSCCode = vendor.IFSCCode ?? "";
//                        vendorDetailsForMail.UserEmail = vendor.ContactPersonEmail;
//                        vendorDetailsForMail.UserName = vendor.ContactPersonName;

//                        await _notificationService.VenderRegistrationWelcomeNotification(vendorDetailsForMail, "Vender.Registration.Notification");

//                        #endregion

//                        var respone = new BaseResponse<string>()
//                        {
//                            Data = "",
//                            Messaage = "Aadhar verified",
//                            Status = Status.Success
//                        };
//                        return Ok(respone);
//                    }
//                    else
//                    {
//                        var respone = new BaseResponse<string>()
//                        {
//                            Data = "",
//                            Messaage = "Vendor data does not exist",
//                            Status = Status.Fail
//                        };
//                        return Ok(respone);
//                    }

//                }
//                else
//                {
//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = "",
//                        Messaage = aadhar.Message,
//                        Status = Status.Fail
//                    };
//                    return Ok(respone);
//                }

//            }
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorOrderAssignDetails(string orderNo)
//        {

//            if (!string.IsNullOrWhiteSpace(orderNo))
//            {
//                var orderDetails = await _completedTripService.GetVendorOrderAssignDetails(orderNo);

//                var respone = new BaseResponse<VendorOrderAssignDetailModel>()
//                {
//                    Data = orderDetails,
//                    Messaage = "Success",
//                    Status = Status.Success
//                };
//                return Ok(respone);
//            }
//            else
//            {
//                var respone = new BaseResponse<VendorOrderAssignDetailModel>()
//                {
//                    Messaage = "Failure",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> DownloadVendorLedger(VendorLedgerModel vendorLedgerModel)
//        {
//            var vendorLedgerHeaderDetails = await _vendorLedgerService.GetVendorLedgerHeaderDetailsAsync(vendorLedgerModel.VendorId, vendorLedgerModel.FromDate, vendorLedgerModel.ToDate);

//            var vendorLedgerOrderItemDetails = await _vendorLedgerService.GetVendorLedgerOrderItemDetailsAsync(vendorLedgerModel.VendorId, vendorLedgerModel.FromDate, vendorLedgerModel.ToDate);
//            if (vendorLedgerHeaderDetails != null)
//            {
//                FileUploadStatusModel ImageResponse = await _fileUploadService.DownloadVendorLedgerAsync(vendorLedgerHeaderDetails, vendorLedgerOrderItemDetails, DocUploadFolderNames.VendorLedgers);

//                if (ImageResponse == null)
//                {
//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = "",
//                        Messaage = "Fail",
//                        Status = Status.Fail
//                    };
//                    return Ok(respone);
//                }
//                else
//                {
//                    var appVersion = await _appVersionService.GetAppVersionByAppName("TBV");
//                    var vendor = await _vendorService.GetVendorAsync((long)vendorLedgerModel.VendorId);

//                    VendorLedgerTemplateModel model = new VendorLedgerTemplateModel();
//                    model.VendorName = vendor.VendorCompanyName;
//                    model.StartDate = vendorLedgerModel.FromDate;
//                    model.EndDate = vendorLedgerModel.ToDate;
//                    model.AppLink = appVersion.AppUrl;
//                    model.UserName = vendor.VendorCompanyName;
//                    model.UserEmail = vendor.ContactPersonEmail;

//                    byte[] imageBytes = null;
//                    using (var client = new HttpClient())
//                    {
//                        using (var response = await client.GetAsync(ImageResponse.Path))
//                        {
//                            imageBytes = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
//                        }
//                    }

//                    string fileName = Path.GetFileName(ImageResponse.Path);
//                    await _notificationService.VendorLedgerNotification(imageBytes , model , "Vendor.Ledger.Template" , fileName);

//                    var respone = new BaseResponse<string>()
//                    {
//                        Data = ImageResponse.Status ? ImageResponse.Path : string.Empty,
//                        Messaage = "Success",
//                        Status = Status.Success
//                    };
//                    return Ok(respone);
//                }
//            }
//            else
//            {
//                var respone = new BaseResponse<string>()
//                {
//                    Data = "",
//                    Messaage = "Fail",
//                    Status = Status.Fail
//                };
//                return Ok(respone);
//            }

//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorBannerList()
//        {
//            var bannerList = await _vendorBannerService.GetVendorBannerListAsync();
//            var vendorBannerList = bannerList.Select(x => x.ToModel<VendorBannerModel>());
//            var respone = new BaseResponse<IEnumerable<VendorBannerModel>>()
//            {
//                Data=vendorBannerList,
//                Messaage = "Success",
//                Status = Status.Success
//            };
//            return Ok(respone);

//        }

//        [HttpGet]
//        public async Task<IActionResult> GetVendorOrderCount(long vendorId)
//        {
//            var count = await _vendorService.GetVendorOrderCount(vendorId);

//            var respone = new BaseResponse<OrderCountModel>()
//            {
//                Data = count,
//                Messaage = "Success",
//                Status = Status.Success
//            };
//            return Ok(respone);

//        }

//        #endregion
//    }
//}
