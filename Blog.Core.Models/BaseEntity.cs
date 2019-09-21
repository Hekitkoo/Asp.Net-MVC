using System;

namespace Blog.Core.Models
{
    /// <summary>
    /// base entity for validation
    /// </summary>
    public abstract class BaseEntity
    {
        public abstract int Id { get; set; }
        public abstract DateTime Date { get; set; }
        public abstract string Text { get; set; }
    }
}