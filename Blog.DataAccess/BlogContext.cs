using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
            Database.SetInitializer(new BlogInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> FeedbackItems { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>()
                .HasRequired<Profile>(s => s.Profile)
                .WithMany(s => s.Questions)
                .HasForeignKey(s => s.ProfileId);
            modelBuilder.Entity<Variant>()
                .HasRequired<Question>(s => s.Question)
                .WithMany(s => s.Variants)
                .HasForeignKey(s => s.QuestionId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}