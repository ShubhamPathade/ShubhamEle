using Microsoft.EntityFrameworkCore;
//using Project.Core.Domain.Dashboard;
//using Project.Core.Domain.Orders;
//using Project.Core.Domain.ProcedureModels;
//using Project.Core.Domain.ProcedureModels.PTLOrders;
//using Project.Core.Domain.Ratings;
//using Project.Core.Domain.PTLOrderWeb.CommonWeb;
//using Project.Core.Domain.PTLOrderWeb.ProcedureModelsWeb;

namespace Project.Data.Mapping
{
    public class ModelMappingRegistrar
    {
        public static void Register(ModelBuilder modelBuilder)
        {
            //    //dashbord Model
            //    modelBuilder.Entity<ManagerDashboardModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CustomerDashboardModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<RunningDeliverOrderModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<RatingDetails>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CustomerOrderModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CustomerTripModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorProfile>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerOrderNotificationTemplateModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerNotificationModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<LoadsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<ConfirmBidModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<LostsBidModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<AllBidsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<ActiveBidsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<BidVendorModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<AcceptPaymentDetails>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<TripOrderModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<AllTripsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<RunningTripsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CompleteTripsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<DeliverWitoutPODModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<AllPODsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorEPODPendingOrRejectedModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<PhysicalPODModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CompletedPODModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OfficeAddressModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OfficeAddressMapList>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorProfileModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CityStateModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<GetVendorRouteModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorDashboardModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<InTransitTripDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<PaymentDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorPaymentsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<TrackingDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CompletedVendorTripsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CompletedVendorTripsSuperModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<TrackingListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CancelTripReportModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<TripReports>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<PODReportModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorLedgerReport>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<TripTrackingMapDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<EPODModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerProfileModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerPaymentDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerAllBidsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerTrackingModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerOrderDropPointsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<GetVendorOrderAssignModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<PickupDropModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<ManagerPaymentDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OrderDetailsForPushNotificationModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<VendorOrderDocumentModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerBidBeforeRejectModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<CustomerBidAfterRejectModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OrderPaymentDetails>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<OrderDetailsForIntugineModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.BidViewModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorNotificationModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<RequisitionReportModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<RequisitionReportCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<InvoiceReportModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<GenerateInvoiceModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<InvoiceHeaderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<InvoiceItemModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<B2BInvoiceListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<InvoiceOrderDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<SMEInvoiceListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<TripOrderListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorOrderDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorOrderAssignDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<SearchLoadsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorLedgerHeaderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorLedgerOrderItemDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CustomerPaymentTripModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorKycDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<AllTripCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<TrackingListCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<EPODTripsCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<ReportCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CheckPODUploadOrNotModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorProfileForCustomerModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<ManagerNotificationModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<LoadsSMEManagerModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<BidsSMEManagerModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<SMEManagerTripModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<SMEManagerPaymentTripModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //    modelBuilder.Entity<AllPODsForSMEManagerModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PaymentDetailsManagerModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<ExpenseSPModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<ExpensePortalModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<CustomerInvoiceDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorSPModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<ExpenseReportModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<AllOrdersCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PTLOrderBidsListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PTLDraftOrderListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.CustomerBidsList>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.BidViewModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PTLLoadModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PTLBidsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.ReadyToShipOrderModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.ShippingLabelDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.ShippingLabelProductDetailsModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlPaymentSummaryModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.WaitingForPickupListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.WaitingForPickupOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.TrackOrderModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlRunningOrderListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlDeliveredOrderListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.VendorOnBoardingDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.Vendors.PtlVendorWaitingForPickUpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.Vendors.PtlVendorReadyForPickupModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.Vendors.PtlVendorRunningOrdersModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.Vendors.PtlVendorDeliveredOrdersModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlVendorOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlProductListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlBidOpenActiveOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.RunningOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.DeliveredOrderDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.Vendors.VendorBranchWithERPListModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<OrderCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<Core.Domain.ProcedureModels.PTLOrders.PtlDraftOrderCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    // New Models Mapping For PTL
            //    modelBuilder.Entity<PtlOrderDetailsSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlWaitingForPickUpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<TotalCountModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlReadyForPickUpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlRunningOrdersModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlDeliveredOrdersSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlBidsForOrderSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlProductDetailModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlBidOpenActiveOrderDetailSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlOrderDetailsWaitingForPickupSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlTrackOrderSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorGlobalSearchSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<VendorLedgerHeaderDetailPTLModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PODReportPtlSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PODReportPtlCountSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlVendorLedgerReportSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<PtlVendorLedgerReportCountSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });

            //    modelBuilder.Entity<AllFTLAndPTLOrdersSpModel>(entity =>
            //    {
            //        entity.HasNoKey();
            //    });
            //}

        }
    }
}
