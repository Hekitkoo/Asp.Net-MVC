using System.Collections.Generic;

namespace Blog.Core.Models
{
    public class ProfileResult
    {
        public int Id { get; set; }
        public Profile Profile { get; set; }
        public Dictionary<Question,Variant> Answers { get; set; }
    }
}