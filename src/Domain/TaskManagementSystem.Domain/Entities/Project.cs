using TaskManagementSystem.Domain.Enums;

namespace TaskManagementSystem.Domain.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public Guid OwnerId { get; set; }
        public ICollection<Guid> MemberIds { get; set; } = new List<Guid>();
        public List<TaskItem> Tasks { get; set; } = new();
        public ProjectStatus ProjectStats { get; set; }

        public UserProfiles Owner { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
