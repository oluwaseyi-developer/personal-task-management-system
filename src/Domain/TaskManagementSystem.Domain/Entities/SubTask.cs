using DomainTaskStatus = TaskManagementSystem.Domain.Enums.TaskStatus;

namespace TaskManagementSystem.Domain.Entities
{
    public class SubTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DomainTaskStatus TaskStatus { get; set; } = DomainTaskStatus.ToDo;

        public Guid ParentTaskId { get; set; }
        public TaskItem ParentTask { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
