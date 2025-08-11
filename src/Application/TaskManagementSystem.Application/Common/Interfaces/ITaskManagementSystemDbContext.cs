// This serves as an abstraction over your DbContext that the Application layer will depend on.
using TaskManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Application.Common.Interfaces
{
    public interface ITaskManagementSystemDbContext
    {
        DbSet<Project> Projects { get; }
        DbSet<TaskItem> Tasks { get; }
        DbSet<UserProfile> Users { get; }
        DbSet<Comment> Comments { get; }
        DbSet<Attachment> Attachments { get; }
        DbSet<Label> Labels { get; }
        DbSet<ActivityLog> ActivityLogs { get; }
        DbSet<SubTask> SubTasks { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
