using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// Article for our Blog
    /// </summary>
    public class Article : BaseEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public override DateTime Date { get; set; }
        public override string Text { get; set; }
    }
}
