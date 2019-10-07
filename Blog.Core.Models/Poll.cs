using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Blog.Core.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool Active { get; set; }
        public ICollection<PollOptions> PollOptionses { get; set; }
    }
}