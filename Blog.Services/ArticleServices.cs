using System.Collections.Generic;
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
            return _context.Articles;
        }
    }
}