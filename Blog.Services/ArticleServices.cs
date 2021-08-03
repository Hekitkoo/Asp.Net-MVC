using System.Data.Entity;
using System.Linq;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class ArticleServices : IArticleServices
    {
        private readonly BlogContext _context;
        public ArticleServices(BlogContext context)
        {
            this._context = context;
        }

        public IQueryable<Article> GetArticles()
        {
            var context = _context.Articles;

            return context;
        }
        public IQueryable<Article> GetTagArticles(string id)
        {
            return _context.Articles.Where(a => a.Tags.Any(t => t.Name == id));
        }
        public Article GetArticle(int? id)
        {
            return _context.Articles
                .Include(s => s.Tags)
                .FirstOrDefault(s => s.Id == id);
        }
    }
}