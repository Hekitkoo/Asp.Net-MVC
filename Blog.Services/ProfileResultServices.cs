using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class ProfileResultServices : IProfileResultServices
    {
        private readonly BlogContext _context;

        public ProfileResultServices(BlogContext context)
        {
            _context = context;
        }
        public ProfileResult CreateAnswer(Profile answer)
        {
           var answerresult = new ProfileResult();

            return answerresult;
        }

        public IQueryable<ProfileResult> GetProfileResults()
        {
            return _context.Answers;
        }
    }
}