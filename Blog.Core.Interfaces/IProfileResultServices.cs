using System.Linq;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IProfileResultServices
    {
        ProfileResult CreateAnswer(Profile profile);
        IQueryable<ProfileResult> GetProfileResults();
    }
}