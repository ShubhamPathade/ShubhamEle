using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Notifications
{
  public  interface IPushToManagerService
    {
        #region Methods
       public void SendPushNotificationToManager(string deviceToken, long companyId, string companyName);
            #endregion
    }
}
