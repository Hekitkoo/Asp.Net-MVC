using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class AnswerServices : IAnswerServices
    {
        private readonly BlogContext _context;

        public AnswerServices(BlogContext context)
        {
            _context = context;
        }
        public ProfileResult CreateAnswer(Profile profile)
        {
            var answer = new ProfileResult();

            foreach (var profileQuestion in profile.Questions)
            {
                foreach (var variant in profileQuestion.Variants)
                {
                    if (variant.Selected)
                    {
                        answer.Answers.Add(profileQuestion, variant);
                    }
                }
            }
            answer.Profile = profile;
            _context.Answers.Add(answer);
            _context.SaveChanges();

            //var answer2 = _context.Answers.Include(a => a.Answers )
            return (answer);
        }
    }
}