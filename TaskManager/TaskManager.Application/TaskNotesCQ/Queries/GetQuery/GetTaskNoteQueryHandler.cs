using MediatR;
using TaskManager.Application.Interfaces;
using TaskManager.Domain;

namespace TaskManager.Application.TaskNotesCQ.Queries.GetQuery
{
    public class GetTaskNoteQueryHandler : IRequestHandler<GetTaskNoteQuery, TaskNoteVm>
    {
        private IRepository<TaskNote> _repository;

        public GetTaskNoteQueryHandler(IRepository<TaskNote> repository)
        {
            _repository = repository;
        }

        public async Task<TaskNoteVm> Handle(GetTaskNoteQuery request, CancellationToken cancellationToken)
        {
            var taskNote = await _repository.GetById(request.Id);

            var vm = new TaskNoteVm
            {
                Id = taskNote.Id,
                Title = taskNote.Title,
                Description = taskNote.Description,
                CreatedDate = taskNote.CreatedDate,
                Deadline = taskNote.Deadline,

            };

            return vm;
        }
    }
}
