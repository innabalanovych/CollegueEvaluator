using CollegueEvaluator.Data.Configuration;
using CollegueEvaluator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegueEvaluator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EvaluationEntityTypeConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Evaluation> Evaluations { get; set; }
    }
}