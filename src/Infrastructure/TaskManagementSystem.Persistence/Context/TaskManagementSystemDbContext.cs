using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Persistence.Context
{
    public class TaskManagementSystemDbContext : DbContext
    {
        public TaskManagementSystemDbContext(DbContextOptions<TaskManagementSystemDbContext> options)
            :base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This helps to apply configuration on each entities
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementSystemDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActivityLog> ActivityLogs => Set<ActivityLog>();
        public DbSet<Attachment> Attachments => Set<Attachment>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Label> Labels => Set<Label>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<SubTask> SubTasks => Set<SubTask>();
        public DbSet<TaskItem> TaskItems => Set<TaskItem>();
        public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
    }
}
