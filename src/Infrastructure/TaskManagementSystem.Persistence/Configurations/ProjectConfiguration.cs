using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project> // This helps to register configuration of each entities
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.Description)
                   .HasMaxLength(1000);

            // One Project Has Many Tasks
            builder.HasMany(p => p.Tasks)
                   .WithOne(ta => ta.Project)
                   .HasForeignKey(ta => ta.ProjectId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
