using System.Collections.Generic;
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

        public string CountProfileResult(Profile profile, sbyte sum)
        {
            return profile.Results[sum];
        }
    }
}
