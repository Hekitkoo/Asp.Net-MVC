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
        public IQueryable<Profile> GetProfiles()
        {
            return _context.Profiles;
        }

        public Profile GetProfile(int? id)
        {
            var profile = _context.Profiles
                .Include(x => x.Questions)
                .FirstOrDefault(p => p.Id == id);
            return profile;
        }
    }
}
