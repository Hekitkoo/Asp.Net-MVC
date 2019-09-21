using System;
using System.Collections.Generic;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class GuestServices : IGuestServices
    {
        private readonly BlogContext _context;

        public GuestServices(BlogContext context)
        {
            _context = context;
        }

        public IEnumerable<Feedback> GetFeedbackItems()
        {
            return _context.FeedbackItems;
        }

        public void AddFeedback(Feedback feedback)
        {
            feedback.Date = DateTime.UtcNow;
            _context.FeedbackItems.Add(feedback);
            _context.SaveChanges();
        }
    }
}