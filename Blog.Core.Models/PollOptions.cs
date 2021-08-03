namespace Blog.Core.Models
{
    public class PollOptions
    {
        public int Id { get; set; }
        public Poll Poll  { get; set; }
        public string Answer { get; set; }
        public int Votes { get; set; }
    }
}