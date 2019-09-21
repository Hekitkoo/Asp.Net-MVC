namespace Blog.Core.Models
{
    /// <summary>
    /// Variant of answer for our profile
    /// </summary>
    public class Variant
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Value { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}