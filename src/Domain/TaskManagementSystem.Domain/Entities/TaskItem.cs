using TaskManagementSystem.Domain.Enums;
using DomainTaskStatus = TaskManagementSystem.Domain.Enums.TaskStatus;

namespace TaskManagementSystem.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;
        public DomainTaskStatus TaskStatus { get; set; } = DomainTaskStatus.ToDo;

        public Guid CreatedById { get; set; } // Owner
        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }
        public Guid? AssignedToId { get; set; }

        public List<Comment> Comments { get; set; } = new();
        public List<Attachment> Attachments { get; set; } = new();
        public List<SubTask> SubTasks { get; set; } = new();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
