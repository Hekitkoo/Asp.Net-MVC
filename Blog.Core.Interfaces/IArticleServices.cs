using System.Linq;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IArticleServices
    {
        IQueryable<Article> GetArticles();
        Article GetArticle(int? id);
        IQueryable<Article> GetTagArticles(string id);

    }
}