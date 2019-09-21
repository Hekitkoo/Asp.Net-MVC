using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// Comments for our Blog
    /// </summary>
    public class Feedback : BaseEntity
    {
        public override int Id { get; set; }
        public string Author { get; set; }
        public override DateTime Date { get; set; }
        public override string Text { get; set; }
    }
}