using System.Collections.Generic;

namespace Blog.Core.Models
{
    /// <summary>
    /// Variant of answer for our profile
    /// </summary>
    public class Variant
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Correct { get; set; }
        public bool Selected { get; set; } 
        public ICollection<Question> Questions { get; set; }
    }
}