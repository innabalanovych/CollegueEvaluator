using CollegueEvaluator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollegueEvaluator.Data.Configuration
{
    public class EvaluationEntityTypeConfiguration : IEntityTypeConfiguration<Evaluation>
    {
        public void Configure(EntityTypeBuilder<Evaluation> builder)
        {
            builder.HasData(SeedingData.GetEvaluations());
        }
    }
}
