using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// Comments for our Blog
    /// </summary>
    public class Feedback : BaseEntity
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}