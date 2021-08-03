using System.Data.Odbc;
using System.Net;
using System.Web.Mvc;
using Blog.Core.Interfaces;
using Blog.Core.Models;

namespace Blog.UI.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        private readonly IProfileServices _profileServices;
        private readonly IAnswerServices _answerServices;
        public ProfileController(IProfileServices profileServices, IAnswerServices answerServices)
        {
            _profileServices = profileServices;
            _answerServices = answerServices;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var profiles = _profileServices.GetProfiles();
            if (profiles == null)
            {
                return HttpNotFound();
            }
            return View(profiles);
        }
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var profile = _profileServices.GetProfile(id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }
        [HttpPost]
        public ActionResult Details(Profile profile)
        {
            var answer = _answerServices.CreateAnswer(profile);
            return RedirectToAction("ProfileResult", answer);
        }

        public ActionResult ProfileResult(ProfileResult answer)
        {
            return View(answer);
        }
    }
}