// Models/Task.cs
namespace AgencyApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public string Priority { get; set; } = string.Empty; // High, Medium, Low
        public int Progress { get; set; }
        public string Client { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
        public int AssignedTo { get; set; }
        public bool IsOverdue { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public List<string>? Attachments { get; set; }
        public List<TaskComment>? Comments { get; set; }
    }

    public class TaskComment
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string? UserAvatar { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}