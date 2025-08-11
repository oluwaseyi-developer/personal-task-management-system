using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Application.Common.Interfaces;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Context
{
    public class TaskManagementSystemDbContext : DbContext, ITaskManagementSystemDbContext
    {
        public TaskManagementSystemDbContext(DbContextOptions<TaskManagementSystemDbContext> options)
            :base(options) { }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<TaskItem> Tasks => Set<TaskItem>();
        public DbSet<UserProfile> Users => Set<UserProfile>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Attachment> Attachments => Set<Attachment>();
        public DbSet<Label> Labels => Set<Label>();
        public DbSet<ActivityLog> ActivityLogs => Set<ActivityLog>();
        public DbSet<SubTask> SubTasks => Set<SubTask>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This helps to apply configuration on each entities
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementSystemDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
