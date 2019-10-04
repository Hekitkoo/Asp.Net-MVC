using System.Collections.Generic;

namespace Blog.Core.Models
{
    /// <summary>
    /// question
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public Profile Profile { get; set; }
    }
}
