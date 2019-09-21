using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IArticleServices
    {
        IEnumerable<Article> GetArticles();

    }
}