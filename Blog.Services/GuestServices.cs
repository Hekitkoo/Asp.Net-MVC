using System;
using System.Collections.Generic;
using System.Linq;
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

        public IQueryable<FeedBack> GetFeedbackItems()
        {
            return _context.FeedbackItems;
        }

        public void CreateFeedback(FeedBack feedBack)
        {
            feedBack.Date = DateTime.UtcNow.ToShortDateString();
            _context.FeedbackItems.Add(feedBack);
            _context.SaveChanges();
        }
    }
}