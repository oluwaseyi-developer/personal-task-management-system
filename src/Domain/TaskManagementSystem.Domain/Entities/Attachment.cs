namespace TaskManagementSystem.Domain.Entities
{
    public class Attachment
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty; //could be url or storage path
        public string? ContentType { get; set; }

        public DateTime UploadAt { get; set; } = DateTime.UtcNow;
        public Guid UploadById { get; set; }
    }
}
