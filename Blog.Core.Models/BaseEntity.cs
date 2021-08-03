using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Models
{
    /// <summary>
    /// base entity for validation
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        /// <value> Mean Author Name in Feedback context </value>
        [Required]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Text { get; set; }
    }
}