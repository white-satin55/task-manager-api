using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.CreateCommand
{
    public class CreateTaskNoteCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
