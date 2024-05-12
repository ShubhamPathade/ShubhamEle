using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Text;

namespace Project.Web.TagHelpers
{
    [HtmlTargetElement("data-list")]
    public class DataListHelper : TagHelper
    {
        [HtmlAttributeName("asp-list")]
        public IList<SelectListItem> ListItems { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "datalist";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("id", "VehicleList");
            var sb = new StringBuilder();
            if (ListItems != null)
            {
                foreach (var item in ListItems)
                {
                    sb.AppendFormat("<option value={0}>{1}</option>",item.Text,item.Text);
                }
            }
           
            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
