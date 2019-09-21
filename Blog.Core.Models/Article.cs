using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// Article for our Blog
    /// </summary>
    public class Article : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
