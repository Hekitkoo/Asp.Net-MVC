using System;
using System.Collections.Generic;

namespace Blog.Core.Models
{
    /// <summary>
    /// Article for our Blog
    /// </summary>
    public class Article : BaseEntity
    {
        public ICollection<Tag> Tags { get; set; }
    }
}
