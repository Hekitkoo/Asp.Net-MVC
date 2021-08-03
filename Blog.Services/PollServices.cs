using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog.Core.Interfaces;
using Blog.Core.Models;
using Blog.DataAccess;

namespace Blog.Services
{
    public class PollServices : IPollServices
    {
        private readonly BlogContext _context;

        public PollServices(BlogContext context)
        {
            _context = context;
        }

        public Poll GetPoll()
        {
            return _context.Polls
                .Include(po => po.PollOptionses)
                .FirstOrDefault();
        }
    }
}