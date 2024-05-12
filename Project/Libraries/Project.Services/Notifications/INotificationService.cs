//using Project.Core.Domain.Orders;
using Project.Core.Domain.Customers;
using System.Threading.Tasks;
using Project.Core.Domain.Vendors;
using Project.Core.Domain.Users;
//using Project.Core.Domain.LREways;
using System.IO;
//using Project.Core.Domain.EmailTemplateModel;

namespace Project.Services.Notifications
{
   public interface INotificationService
    {
        #region Methods

        //Task<bool> TestEmailNotification();
        ////Task<bool> CustomerOrderPlaceNotification(CustomerOrderNotificationTemplateModel templateModel, string templateName);
        //Task<bool> CustomerRegistrationNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName);
        //Task<bool> VenderRegistrationNotification(VenderRegistrationNotificationTemplateModel templateModel, string templateName);
        ////Task<bool> PodSubmissionNotification(PodSubmissionNotificationTemplate templateModel, string templateName);
        //Task<bool> USerRegistrationNotification(UserEmailNotification templateModel, string templateName);
        ////Task<bool> OrderDocumentNotification(OrderDocumentNotificationTemplate templateModel, string templateName);
        ////Task<bool> LREwayNotification(LREwayNotificationTemplateModel templateModel, string templateName);
        //Task<bool> VenderRegistrationWelcomeNotification(VenderRegistrationNotificationTemplateModel templateModel, string templateName);
        //Task<bool> CustomerRegistrationWelcomeNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName);
        ////Task<bool> CustomerInvoiceNotification(byte[] bytes, CustomerInvoiceModel templateModel, string templateName, string attachmentFileName = null);
        //Task<bool> CustomerRegistrationOnboardingNotification(CustomerRegistrationNotificationTemplateModel templateModel, string templateName);
        //Task<bool> CustomerAdvancePaymentNotification(CustomerAdvancePaymentModel templateModel, string templateName);
        //Task<bool> VendorAdvancePaymentNotification(VendorAdvancePaymentModel templateModel, string templateName);
        //Task<bool> VendorBalancePaymentNotification(VendorBalancePaymentModel templateModel, string templateName);
        //Task<bool> CustomerOrderDocumentNotification(CustomerOrderDocumentTemplateModel templateModel, string templateName);
        //Task<bool> VendorLedgerNotification(byte[] bytes, VendorLedgerTemplateModel templateModel, string templateName, string attachmentFileName = null);
        //Task<bool> VendorLRDocumentNotification(byte[] bytes, VendorLRDocumentTemplateModel templateModel, string templateName, string attachmentFileName = null);
        //Task<bool>  VendorShippingLabelNotification(byte[] bytes, VendorShippingLabelTemplateModel templateModel, string templateName, string attachmentFileName = null);
        //Task<bool> CustomerShippingLabelNotification(byte[] bytes, CustomerShippingLabelTemplateModel templateModel, string templateName, string attachmentFileName = null);

        #endregion
    }
}
