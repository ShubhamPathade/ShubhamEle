using Project.Web.Framework.Models;
using System.Collections;

namespace Project.Web.Models.BaseResponse
{
	public class BaseResponse<T>
	{
		#region Properties

		public Status Status { get; set; }

		public T Data { get; set; }

		public string Message { get; set; }
		public bool ErrorOccured { get; set; }

		#endregion
	}
}
