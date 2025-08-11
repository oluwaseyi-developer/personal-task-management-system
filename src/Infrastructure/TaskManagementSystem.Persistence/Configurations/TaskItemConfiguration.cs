using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Configurations
{
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasKey(ti => ti.Id);

            builder.Property(ti => ti.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(d => d.Description)
                   .HasMaxLength(2000);

            // One Task Belongs To One Project
            builder.HasOne(ti => ti.Project)
                   .WithMany(pr => pr.Tasks)
                   .HasForeignKey(ti => ti.ProjectId)
                   .OnDelete(DeleteBehavior.Cascade);

            // One Task Has Many Comment
            builder.HasMany(ti => ti.Comments)
                   .WithOne()
                   .HasForeignKey(co => co.TaskId)
                   .OnDelete(DeleteBehavior.Cascade);

            // One Task Has Many Attachment
            builder.HasMany(t => t.Attachments)
                    .WithOne(a => a.Task)
                    .HasForeignKey(a => a.TaskId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.SubTasks)
                   .WithOne(st => st.ParentTask)
                   .HasForeignKey(st => st.ParentTaskId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
