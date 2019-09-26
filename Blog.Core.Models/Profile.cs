using System.Collections.Generic;

namespace Blog.Core.Models
{
    /// <summary>
    /// Profile for our Blog
    /// </summary>
    public class Profile
    {
        public int Id { get; set; }
        public string ProfilePreview { get; set; }
        public List<Question> Questions { get; set; }
    }
}
