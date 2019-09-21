using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// base entity for validation
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}