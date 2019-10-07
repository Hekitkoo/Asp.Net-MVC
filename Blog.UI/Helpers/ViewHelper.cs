using System.Collections.Generic;
using System.Web.Mvc;
using Blog.Core.Models;

namespace Blog
{
    public static class ViewHelper
    {
        public static MvcHtmlString CardList(this HtmlHelper helper, IEnumerable<BaseEntity> items)
    {
        TagBuilder card = new TagBuilder("div");
        foreach (var item in items)
        {
            TagBuilder cardBorder = new TagBuilder("div");
            cardBorder.AddCssClass("card border mb-1 bg-light");
            TagBuilder cardHeader = new TagBuilder("h5");
            cardHeader.AddCssClass("card-header bg-light");
            cardHeader.SetInnerText(item.Name);
            //cardBorder.InnerHtml += cardHeader.ToString();
            TagBuilder cardBody = new TagBuilder("div");
            cardBody.AddCssClass("card-body");
            TagBuilder cardText = new TagBuilder("p");
            cardText.AddCssClass("card-text");
            cardText.SetInnerText(item.Text);
            TagBuilder cardFooter = new TagBuilder("cite");
            cardFooter.AddCssClass("card-footer");
            cardFooter.SetInnerText(item.Date);
            cardText.InnerHtml += cardFooter.ToString();
            cardBody.InnerHtml += cardText.ToString();
            cardHeader.InnerHtml += cardBody.ToString();
            cardBorder.InnerHtml += cardHeader.ToString();

            card.InnerHtml += cardBorder.ToString();
        }

        return new MvcHtmlString(card.ToString());
    }
}
}