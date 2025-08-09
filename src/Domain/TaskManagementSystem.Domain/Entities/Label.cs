namespace TaskManagementSystem.Domain.Entities
{
    public class Label
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<TaskItem> Tasks { get; set; } = new();
    }
}
