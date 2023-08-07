using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.DeleteCommand
{
    public class DeleteTaskNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
