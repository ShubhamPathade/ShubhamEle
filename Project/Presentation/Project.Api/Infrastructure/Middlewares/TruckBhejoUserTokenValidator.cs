using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Project.Api.Models;
//using Project.Api.Models.Common;
using Project.Core.Constants;
//using Project.Core.Domain.ProcedureModels;
//using Project.Core.Domain.Students;
//using Project.Services.Customers;
//using Project.Services.Managers;
//using Project.Services.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.Api.Infrastructure.Middlewares
{
    public class TruckBhejoUserTokenValidator
    {
        private readonly RequestDelegate _next;
        object user;

        public TruckBhejoUserTokenValidator(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task Invoke(HttpContext httpContext, IManagerService managers, ICustomerService customers, IVendorService vendors)
        //{
        //    if (httpContext.User.Identity.IsAuthenticated)
        //    {
        //        var authHeaderValue = httpContext.Request.Headers.FirstOrDefault(x => x.Key.Equals("Authorization")).Value;
        //        if (authHeaderValue.Any())
        //        {
        //            var token = authHeaderValue.FirstOrDefault()?.Split(" ").ElementAtOrDefault(1);
        //            var userType = httpContext.User.FindFirst(ClaimTypes.Role).Value;
        //            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        //            #region Validating user token is exist or not

        //            if (userType == UserType.Manager)
        //            {
        //                //check manager type
        //                long managerId = await managers.GetManagerType(Convert.ToInt64(userId));
        //                if(managerId==ManagerType.Basic)
        //                user = await managers.CheckApiToken(token);
        //            }
        //            if (userType == UserType.Customer)
        //            {
        //                user = await customers.CheckApiToken(token);
        //            }
        //            if (userType == UserType.Vendor)
        //            {
        //                user = await vendors.CheckApiToken(token);
        //            }

        //            if (user == null)
        //            {
        //                //var responseModel = new BaseResponse<List<string>>()
        //                //{
        //                //    Data = new List<string>(),
        //                //    Messaage = "Invalid ApiToken",
        //                //    Status = Status.ApiToken
        //                //};
        //                //var response = JsonConvert.SerializeObject(responseModel);
        //                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
        //                return;
        //                //await httpContext.Response.WriteAsync(response);
        //            }

        //            #endregion
        //        }
        //    }
        //    await _next.Invoke(httpContext);
        //}
    }
}
