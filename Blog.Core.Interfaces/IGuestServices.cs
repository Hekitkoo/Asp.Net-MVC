using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.Core.Interfaces
{
    public interface IGuestServices
    {
        IEnumerable<Feedback> GetFeedbackItems();

        void AddFeedback(Feedback feedback);
    }
}