using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;

namespace Blog.UI.Controllers
{
    public class GuestController : Controller
    {
        private IGuestServices _service;

        public GuestController(IGuestServices service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_service.GetFeedbackItems());
        }
        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            _service.AddFeedback(feedback);
            return RedirectToAction("Index");
        }
    }
}