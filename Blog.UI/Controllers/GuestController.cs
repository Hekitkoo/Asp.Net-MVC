using System.Linq;
using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.UI.Models;

namespace Blog.UI.Controllers
{
    public class GuestController : Controller
    {
        private readonly IGuestServices _service;

        public GuestController(IGuestServices service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var items = _service.GetFeedbackItems();
            if (items != null && items.Any())
            {
                FeedBackViewModel feedBackViewModel = new FeedBackViewModel
                {
                    FeedBacks = items,
                    NewFeedBack = new FeedBack()
                };
                return View(feedBackViewModel);
            }

            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Index(FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                _service.CreateFeedback(feedBack);
            }
            return RedirectToAction("Index");
        }
    }
}