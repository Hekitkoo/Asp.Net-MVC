using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.UI.Models
{
    public class FeedBackViewModel
    {
        public IEnumerable<FeedBack> FeedBacks { get; set; }
        public FeedBack NewFeedBack { get; set; }  
    }
}