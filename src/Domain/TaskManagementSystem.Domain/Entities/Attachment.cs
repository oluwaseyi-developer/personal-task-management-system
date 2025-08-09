namespace TaskManagementSystem.Domain.Entities
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string? ContentType { get; set; }

        public DateTime UploadAt { get; set; } = DateTime.UtcNow;
        public Guid UploadById { get; set; }

        public UserProfiles UploadBy { get; set; }
        public Task Task { get; set; }
    }
}
