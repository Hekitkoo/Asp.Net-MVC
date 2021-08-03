using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Blog.Core.Models;

namespace Blog.UI.Models
{
    public class FeedBackViewModel
    {
        public IEnumerable<FeedBack> FeedBacks { get; set; }
        [Required]
        public FeedBack NewFeedBack { get; set; }  
    }
}