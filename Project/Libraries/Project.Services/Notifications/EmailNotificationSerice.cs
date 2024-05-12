using Project.Core.Data;
using Project.Core.Domain.Customers;
//using Project.Core.Domain.Notifications;
using Project.Core.Domain.Vendors;
//using Project.Core.Domain.Orders;
using Project.Core.Domain.Users;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
//using Project.Core.Domain.LREways;
using System.IO;
using Project.Core.Constants;
//using Project.Core.Domain.EmailTemplateModel;

namespace Project.Services.Notifications
{
    public class EmailNotificationSerice : INotificationService
    {
        //#region Fields

        //private readonly IMessageTemplateService _messageTemplateService;
        //private readonly IEmailAccountService _emailAccountService;

        //#endregion

        //#region Constructor

        //public EmailNotificationSerice(IMessageTemplateService messageTemplateService, IEmailAccountService emailAccountService)
        //{
        //    _messageTemplateService = messageTemplateService;
        //    _emailAccountService = emailAccountService;
        //}

        //#endregion

        //#region Utilities

        //public void SendEmail(EmailAccount emailAccount, string subject, string body, string toUserName, string toEmailAddress,byte[] bytes = null, string attachmentFileName = null)
        //{
        //    var message = new MailMessage
        //    {
        //        From = new MailAddress(emailAccount.Email, emailAccount.DisplayName)
        //    };
        //    message.To.Add(new MailAddress(toEmailAddress, toUserName ?? toEmailAddress));

        //    //create stream attachmenet
        //    if (bytes != null)
        //    {
        //        var stream = new MemoryStream(bytes);
        //        stream.Position = 0;
        //        message.Attachments.Add(new Attachment(stream, attachmentFileName, MimeTypes.ApplicationPdf));
        //    }

        //    //content
        //    message.Subject = subject;
        //    message.Body = body;
        //    message.IsBodyHtml = true;

        //    //send email
        //    using (var smtpClient = new SmtpClient())
        //    {
        //        smtpClient.UseDefaultCredentials = false;
        //        smtpClient.Host = emailAccount.Host;
        //        smtpClient.Port = emailAccount.Port;
        //        smtpClient.EnableSsl = true;
        //        smtpClient.Credentials = new NetworkCredential(emailAccount.UserName, emailAccount.Password);
        //        smtpClient.Send(message);
        //    }
        //}

        //#endregion

        //#region Methods

        //public async Task<bool> TestEmailNotification()
        //{
        //    var template = await _messageTemplateService.GetMessageTemplateAsync("Customer.OrderDocument");

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, "Manjunath", "manjunathkarakal20@gmail.com");

        //    return true;
        //}
        //public async Task<bool> CustomerRegistrationNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%CustomerEmail%", templateModel.CustomerEmail);
        //    stringBuilder.Replace("%CustomerNo%", templateModel.CustomerNo);
        //    stringBuilder.Replace("%CustomerAddress%", templateModel.CustomerAddress);
        //    stringBuilder.Replace("%CompanyName%", templateModel.CompanyName);
        //    stringBuilder.Replace("%UserName%", templateModel.UserName);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> USerRegistrationNotification(UserEmailNotification templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CallBackUrl%", templateModel.CallBackUrl);
        //    stringBuilder.Replace("%UserName%", templateModel.UserName);
        //    stringBuilder.Replace("%Password%", templateModel.Password);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> VenderRegistrationNotification(VenderRegistrationNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%VendorCompanyName%", templateModel.VendorCompanyName);
        //    stringBuilder.Replace("%AadharNumber%", templateModel.AadharNumber);
        //    stringBuilder.Replace("%PanNumber%", templateModel.PanNumber);
        //    stringBuilder.Replace("%OfficeAddress%", templateModel.OfficeAddress);
        //    stringBuilder.Replace("%ContactPersonName%", templateModel.ContactPersonName);
        //    stringBuilder.Replace("%ContactPersonNumber%", templateModel.ContactPersonNumber);
        //    stringBuilder.Replace("%ContactPersonEmail%", templateModel.ContactPersonEmail);
        //    stringBuilder.Replace("%BankAcNumbe%", templateModel.BankAcNumber);
        //    stringBuilder.Replace("%BankName%", templateModel.BankName);
        //    stringBuilder.Replace("%IFSCCode%", templateModel.IFSCCode);
        //    stringBuilder.Replace("%UserName%", templateModel.UserName);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> PodSubmissionNotification(PodSubmissionNotificationTemplate templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%TruckNumber%", templateModel.TruckNumber);
        //    stringBuilder.Replace("%CompanyName%", templateModel.CompanyName);
        //    stringBuilder.Replace("%PickupPoint%", templateModel.PickupPoint);
        //    stringBuilder.Replace("%DropPoint%", templateModel.DropPoint);
        //    stringBuilder.Replace("%LrnNumber%", templateModel.LRNumber);
        //    stringBuilder.Replace("%Feedback%", templateModel.Remarks);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> OrderDocumentNotification(OrderDocumentNotificationTemplate templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%ManagerName%", templateModel.ManagerName);
        //    stringBuilder.Replace("%PickupPoint%", templateModel.PickupPoint);
        //    stringBuilder.Replace("%DropPoint%", templateModel.DropPoint);
        //    stringBuilder.Replace("%LrnNumber%", templateModel.LRNumber);
        //    stringBuilder.Replace("%EwayBillNumber%", templateModel.EwayBillNumber);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> LREwayNotification(LREwayNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNumber);
        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%OperationManager%", templateModel.OperationManager);
        //    stringBuilder.Replace("%PickupPoint%", templateModel.PickLocation);
        //    stringBuilder.Replace("%DropPoint%", templateModel.DropLocation);
        //    stringBuilder.Replace("%LRNumber%", templateModel.LRNumber);
        //    stringBuilder.Replace("%EwayBillNumber%", templateModel.EwayBillNumber);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();
        //    var subject = $" Order Documents Received {templateModel.OrderNumber} for {templateModel.CustomerName}";

        //    SendEmail(account, subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> VenderRegistrationWelcomeNotification(VenderRegistrationNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%VendorCompanyName%", templateModel.VendorCompanyName);
        //    stringBuilder.Replace("%AadharNumber%", templateModel.AadharNumber);
        //    stringBuilder.Replace("%PanNumber%", templateModel.PanNumber);
        //    stringBuilder.Replace("%OfficeAddress%", templateModel.OfficeAddress);
        //    stringBuilder.Replace("%ContactPersonName%", templateModel.ContactPersonName);
        //    stringBuilder.Replace("%ContactPersonNumber%", templateModel.ContactPersonNumber);
        //    stringBuilder.Replace("%ContactPersonEmail%", templateModel.ContactPersonEmail);
        //    stringBuilder.Replace("%BankAcNumbe%", templateModel.BankAcNumber);
        //    stringBuilder.Replace("%BankName%", templateModel.BankName);
        //    stringBuilder.Replace("%IFSCCode%", templateModel.IFSCCode);
        //    stringBuilder.Replace("%UserName%", templateModel.UserName);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();
        //    var subject = "Vender Registration Approved";

        //    SendEmail(account, subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> CustomerRegistrationWelcomeNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%CustomerEmail%", templateModel.CustomerEmail);
        //    stringBuilder.Replace("%CustomerNo%", templateModel.CustomerNo);
        //    stringBuilder.Replace("%CustomerAddress%", templateModel.CustomerAddress);
        //    stringBuilder.Replace("%CompanyName%", templateModel.CompanyName);
        //    stringBuilder.Replace("%UserName%", templateModel.UserName);
        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();
        //    string subject = "Customer Registration Approved";

        //    SendEmail(account, subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> CustomerInvoiceNotification(byte[] bytes, CustomerInvoiceModel templateModel, string templateName, string attachmentFileName = null)
        //{
        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    string subject = $"Load Invoice for #{templateModel.OrderNo}";          

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%InvoiceNumber%", templateModel.InvoiceNumber);
        //    stringBuilder.Replace("%ProductName%", templateModel.ProductName);
        //    stringBuilder.Replace("%Source%", templateModel.Source);
        //    stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    stringBuilder.Replace("%TotalAmountPaid%", templateModel.TotalAmountPaid.ToString());
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    SendEmail(account, subject, body, templateModel.UserName , templateModel.UserEmail , bytes, attachmentFileName);
        //    return true;
        //}
        //public async Task<bool> CustomerRegistrationOnboardingNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> CustomerAdvancePaymentNotification(CustomerAdvancePaymentModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%AdvanceAmount%", templateModel.AdvanceAmount.ToString());
        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%ProductName%", templateModel.ProductName);
        //    stringBuilder.Replace("%Source%", templateModel.Source);
        //    stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    stringBuilder.Replace("%UTRNumber%", templateModel.UTRNumber);
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> VendorAdvancePaymentNotification(VendorAdvancePaymentModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%AdvanceAmount%", templateModel.AdvanceAmount.ToString());
        //    stringBuilder.Replace("%ProductName%", templateModel.ProductName);
        //    stringBuilder.Replace("%Source%", templateModel.Source);
        //    stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    stringBuilder.Replace("%UTRNumber%", templateModel.UTRNumber);
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> VendorBalancePaymentNotification(VendorBalancePaymentModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%BalanceAmount%", templateModel.BalanceAmount.ToString());
        //    stringBuilder.Replace("%ProductName%", templateModel.ProductName);
        //    stringBuilder.Replace("%Source%", templateModel.Source);
        //    stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    stringBuilder.Replace("%UTRNumber%", templateModel.UTRNumber);
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> CustomerOrderDocumentNotification(CustomerOrderDocumentTemplateModel templateModel, string templateName)
        //{
        //    if (templateModel == null || string.IsNullOrEmpty(templateName))
        //        throw new ArgumentNullException();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%CustomerName%", templateModel.CustomerName);
        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%AdvanceAmount%", templateModel.AdvanceAmount.ToString());
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail);

        //    return true;
        //}
        //public async Task<bool> VendorLedgerNotification(byte[] bytes, VendorLedgerTemplateModel templateModel, string templateName, string attachmentFileName = null)
        //{
        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    stringBuilder.Replace("%StartDate%", templateModel.StartDate.Value.ToString("dd MMM yyyy"));
        //    stringBuilder.Replace("%EndDate%", templateModel.EndDate.Value.ToString("dd MMM yyyy"));
        //    stringBuilder.Replace("%AppLink%", templateModel.AppLink);

        //    string body = stringBuilder.ToString();

        //    SendEmail(account, template.Subject, body, templateModel.UserName, templateModel.UserEmail, bytes, attachmentFileName);
        //    return true;
        //}
        //public async Task<bool> VendorLRDocumentNotification(byte[] bytes, VendorLRDocumentTemplateModel templateModel, string templateName, string attachmentFileName = null)
        //{
        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    stringBuilder.Replace("%Source%", templateModel.Source);
        //    stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    stringBuilder.Replace("%VehicleNumber%", templateModel.VehicleNumber);

        //    string subject = $"Loading slip of Order Number {templateModel.OrderNo}";
        //    string body = stringBuilder.ToString();

        //    SendEmail(account, subject, body, templateModel.UserName, templateModel.UserEmail, bytes, attachmentFileName);
        //    return true;
        //}

        //public async Task<bool> VendorShippingLabelNotification(byte[] bytes, VendorShippingLabelTemplateModel templateModel, string templateName, string attachmentFileName = null)
        //{
        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    //var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    //StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    //stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    //stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    //stringBuilder.Replace("%Source%", templateModel.Source);
        //    //stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    //stringBuilder.Replace("%VehicleNumber%", templateModel.VehicleNumber);

        //    string subject = $"Shipping Label for order Number {templateModel.OrderNo}";
        //    string body = "Please find attached shipping label";

        //    SendEmail(account, subject, body, templateModel.VendorName, templateModel.VendorEmail, bytes, attachmentFileName);
        //    return true;
        //}

        //public async Task<bool> CustomerShippingLabelNotification(byte[] bytes, CustomerShippingLabelTemplateModel templateModel, string templateName, string attachmentFileName = null)
        //{
        //    var account = await _emailAccountService.GetDefaultEmailAccountAsync();

        //    //var template = await _messageTemplateService.GetMessageTemplateAsync(templateName);

        //    //StringBuilder stringBuilder = new StringBuilder(template.Body);

        //    //stringBuilder.Replace("%OrderNo%", templateModel.OrderNo);
        //    //stringBuilder.Replace("%VendorName%", templateModel.VendorName);
        //    //stringBuilder.Replace("%Source%", templateModel.Source);
        //    //stringBuilder.Replace("%Destination%", templateModel.Destination);
        //    //stringBuilder.Replace("%VehicleNumber%", templateModel.VehicleNumber);

        //    string subject = $"Shipping Label for order Number {templateModel.OrderNo}";
        //    string body = "Please find attached shipping label";

        //    SendEmail(account, subject, body, templateModel.CustomerName, templateModel.CustomerEmail, bytes, attachmentFileName);
        //    return true;
        //}

        //#endregion
    }
}
