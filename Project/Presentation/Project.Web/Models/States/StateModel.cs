using Project.Web.Models.Common;

namespace Project.Web.Models.States
{
	public class StateModel:BaseEntityModel
	{
		public string Name { get; set; }
		public PostModel PostModel { get; set; }
    }
}
