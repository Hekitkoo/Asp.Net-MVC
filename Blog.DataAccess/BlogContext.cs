using System.Data.Entity;
using Blog.Core.Models;

namespace Blog.DataAccess
{
    /// <summary>
    /// Context for our Project
    /// </summary>
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new BlogInitializer());
        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollOptions> PollOptionses { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<FeedBack> FeedbackItems { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileResult> Answers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(t => t.Tags)
                .WithMany(a => a.Articles);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Poll>()
                .HasMany(p => p.PollOptionses)
                .WithRequired(p => p.Poll);
            //modelBuilder.Configurations.Add(new );
        }
    }
}