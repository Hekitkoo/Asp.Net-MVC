using System.Web.Mvc;

namespace Blog
{
    public static class ViewHelper
    {
        /// <summary>
        /// Select list helper
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static MvcHtmlString UnOrderedList(this HtmlHelper helper, string item)
        {
            TagBuilder tagUl = new TagBuilder("ul");

            TagBuilder tagLi = new TagBuilder("li")
                {
                    InnerHtml = item
                };
                tagUl.InnerHtml += tagLi;
            return new MvcHtmlString(tagUl.ToString());
        }
    }
}