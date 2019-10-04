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
        public ProfileResult CreateAnswer(Profile profile)
        {
            var answer = new ProfileResult();
            answer.Profile = profile;
            foreach (var profileQuestion in profile.Questions)
            {
                answer.Answers.Add(profileQuestion);
            }
           
            _context.Answers.Add(answer);
            _context.SaveChanges();

            return (answer);
        }

        public IQueryable<ProfileResult> GetProfileResults()
        {
            return _context.Answers;
        }
    }
}