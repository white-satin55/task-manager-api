using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.UpdateCommand
{
    public class UpdateTaskNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
