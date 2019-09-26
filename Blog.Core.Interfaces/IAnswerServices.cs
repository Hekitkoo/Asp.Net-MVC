using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IAnswerServices
    {
        ProfileResult CreateAnswer(Profile profile);
    }
}