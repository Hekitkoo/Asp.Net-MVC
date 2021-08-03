using System.Linq;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IGuestServices
    {
        IQueryable<FeedBack> GetFeedbackItems();

        void CreateFeedback(FeedBack feedback);
    }
}