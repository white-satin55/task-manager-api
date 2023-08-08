using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Queries.GetQuery
{
    public class GetTaskNoteQuery : IRequest<TaskNoteVm>
    {
        public Guid Id { get; set; }
    }
}
