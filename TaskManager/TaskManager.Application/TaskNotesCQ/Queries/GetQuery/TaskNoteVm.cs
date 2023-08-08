using AutoMapper;

namespace TaskManager.Application.TaskNotesCQ.Queries.GetQuery
{
    public class TaskNoteVm 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
