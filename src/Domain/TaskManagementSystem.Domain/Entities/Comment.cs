namespace TaskManagementSystem.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid AuthorId { get; set; }
        public string Remark { get; set; } = string.Empty;

        public Task Task { get; set; }
        public UserProfiles Author { get; set; }
        
    }
}
