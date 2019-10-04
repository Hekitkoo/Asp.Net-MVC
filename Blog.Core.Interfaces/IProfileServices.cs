using System.Linq;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IProfileServices
    {
        IQueryable<Profile> GetProfiles();
        Profile GetProfile(int? id);
        
    }
}