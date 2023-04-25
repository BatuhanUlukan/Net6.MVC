using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NET6.Entity.Entities;
using System.Reflection;

namespace NET6.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Seo> Seos { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<ArticleVisitor> ArticleVisitors { get; set; }
        public DbSet<PortfolioVisitor> PortfolioVisitors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
