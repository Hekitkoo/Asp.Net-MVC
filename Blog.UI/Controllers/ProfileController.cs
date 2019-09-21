using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;

namespace Blog.UI.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        private IProfileServices _service;

        public ProfileController(IProfileServices service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(_service.GetProfiles());
        }
        [HttpPost]
        public ActionResult Index(Profile profile)
        {
            _service.CountProfileResult(profile, ViewBag.sum);
            return RedirectToAction("Index");
        }

        public ActionResult Result(string result)
        {
            return View(result);
        }
    }
}