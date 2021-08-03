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
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        ///<value> it more comfortable form for view information</value>
        public string Date { get; set; }
        [Required(ErrorMessage = "Text Required")]
        public string Text { get; set; }
    }
}