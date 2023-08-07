

namespace TaskManager.Domain
{
    public class TaskNote
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
