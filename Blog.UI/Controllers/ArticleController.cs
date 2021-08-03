using System.Web.Mvc;
using Blog.Core.Interfaces;

namespace Blog.UI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleServices _service;

        public ArticleController(IArticleServices service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            return View(_service.GetArticles());
        }

    }
}