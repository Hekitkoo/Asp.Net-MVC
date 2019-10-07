using System.Linq;
using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.UI.Models;

namespace Blog.UI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleServices _articleServices;
        private readonly IPollServices _pollServices;

        public ArticleController(IArticleServices articleServices, IPollServices pollService)
        {
            _articleServices = articleServices;
            _pollServices = pollService;
        }
        public ActionResult Index()
        {
            var articles = _articleServices.GetArticles();
            var poll = _pollServices.GetPoll();
            if ((articles != null && articles.Any() && (poll != null)))
            {
                foreach (var article in articles)
                {
                    article.Text = article.Text.Substring(0,200);
                }

                var articlePoll = new ArticlePollModel
                {
                    Poll = poll,
                    Articles = articles
                };

                return View(articlePoll);
            }

            return HttpNotFound();
        }
        public ActionResult Tag(string id)
        {
            var articles = _articleServices.GetTagArticles(id);
            if (articles != null && articles.Any())
            {
                foreach (var article in articles)
                {
                    article.Text = article.Text.Substring(0, 200);
                }
                return View(articles);
            }
            return HttpNotFound();
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                var article = _articleServices.GetArticle(id);
                if (article != null)
                {
                    article.Date = article.Date;

                    return View(_articleServices.GetArticle(id));
                }
            }
            return HttpNotFound();
        }
    }
}