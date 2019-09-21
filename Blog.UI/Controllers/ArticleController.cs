using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.UI.Controllers
{
    public class ArticleController : Controller
    {
        IArticleServices _service;

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