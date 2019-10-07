using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Models
{
    /// <summary>
    /// question
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Profile Profile { get; set; }
    }
}
