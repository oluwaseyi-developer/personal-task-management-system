using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class SubTaskConfiguration : IEntityTypeConfiguration<SubTask>
    {
        public void Configure(EntityTypeBuilder<SubTask> builder)
        {
            builder.HasKey(st => st.Id);

            builder.Property(st => st.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasOne(st => st.ParentTask)
                   .WithMany(t => t.SubTasks)
                   .HasForeignKey(st => st.ParentTaskId);

        }
    }
}
