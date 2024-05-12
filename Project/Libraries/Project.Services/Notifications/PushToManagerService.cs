using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Project.Services.Notifications
{
    public class PushToManagerService : IPushToManagerService
    {

        //#region Properties
        //private string serverKey = "AAAACqTzCtQ:APA91bEe7P5JWugXGcIGXfYJr43VNSwcY4PjCOYQBv3xXE4D7jOYMWe4zKlwRKOGGA5IJIWg0RhU1bIj-1wzHlhai0hl_phA1ZO0xgz9rq9fG1wM7HHB9r_-7vR1ZSMfDzG8iD9qa2hi";

        //private string senderId = "45717064404";

        //private string webAddr = "https://fcm.googleapis.com/fcm/send";
       // #endregion

        #region Methods
        public void SendPushNotificationToManager(string deviceToken, long companyId, string companyName)
        {
            //dynamic objData = new
            //{
            //    to = deviceToken, 
                                 
            //    notification = new
            //    {
            //        title = "New Load",     // Notification title
            //        action = "New Load Posted by " + companyName + " Deploy Vehicle Now",    // Notification body data
            //        type = "newLoad",
            //        orderId=companyName,
            //        companyId=companyId
            //    },
            //};
//                var serializer = new System.Web.Serialization.JavaScriptSerializer();
//            var json = serializer.Serialize(objData);
//            Byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(json);
//​
//                string SERVER_API_KEY = serverKey;
//            string SENDER_ID = senderId;
//​
//                WebRequest tRequest;
//            tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
//            tRequest.Method = "post";
//            tRequest.ContentType = "application/json";
//            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));
//​
//                tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));
//​
//                tRequest.ContentLength = byteArray.Length;
//            Stream dataStream = tRequest.GetRequestStream();
//            dataStream.Write(byteArray, 0, byteArray.Length);
//            dataStream.Close();
//​
//                WebResponse tResponse = tRequest.GetResponse();
//​
//                dataStream = tResponse.GetResponseStream();
//​
//                StreamReader tReader = new StreamReader(dataStream);
//​
//                String sResponseFromServer = tReader.ReadToEnd();
            //    tReader.Close();
            //dataStream.Close();
            //tResponse.Close();
        }

        #endregion

    }
}
