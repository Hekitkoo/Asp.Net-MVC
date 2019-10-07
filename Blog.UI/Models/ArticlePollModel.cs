using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.UI.Models
{
    public class ArticlePollModel
    {
        public IEnumerable<Article> Articles { get; set; }
        public Poll Poll { get; set; }
    }
}