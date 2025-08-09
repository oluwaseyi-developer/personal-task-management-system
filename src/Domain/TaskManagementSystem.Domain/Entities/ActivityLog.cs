namespace TaskManagementSystem.Domain.Entities
{
    public class ActivityLog
    {
        public int Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid PerformedById { get; set; }
        public string Action { get; set; } = string.Empty; //e.g "Status Created", "Task Created"

        DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
