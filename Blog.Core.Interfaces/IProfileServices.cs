using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IProfileServices
    {
        IEnumerable<Profile> GetProfiles();
        string CountProfileResult(Profile profile, sbyte sum);
    }
}