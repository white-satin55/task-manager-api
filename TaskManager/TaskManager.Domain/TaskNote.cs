

namespace TaskManager.Domain
{
    public class TaskNote
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
