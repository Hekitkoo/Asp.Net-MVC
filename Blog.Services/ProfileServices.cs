using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class ProfileServices : IProfileServices
    {
        private readonly BlogContext _context;

        public ProfileServices(BlogContext context)
        {
            _context = context;
        }
        public IEnumerable<Profile> GetProfiles()
        {
            return _context.Profiles;
        }

        public Profile GetProfile(int? id)
        {
            var profile = _context.Profiles
                .Include(x => x.Questions)
                .FirstOrDefault(p => p.Id == id);
            foreach (var profileQuestion in profile.Questions)
            {
                profileQuestion.Variants =
                    _context.Variants
                        .Where(v => v.Questions
                            .Select(q => q.Id)
                            .Contains(profileQuestion.Id))
                        .ToList();
            }
            return profile;
        }
    }
}
