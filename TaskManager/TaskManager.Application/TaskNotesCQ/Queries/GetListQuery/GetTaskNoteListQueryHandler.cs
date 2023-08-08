using MediatR;
using TaskManager.Application.Interfaces;
using TaskManager.Domain;

namespace TaskManager.Application.TaskNotesCQ.Queries.GetListQuery
{
    public class GetTaskNoteListQueryHandler : IRequestHandler<GetTaskNoteListQuery, TaskNoteListVm>
    {
        private IRepository<TaskNote> _repository;
        public GetTaskNoteListQueryHandler(IRepository<TaskNote> repository)
        {
            _repository = repository;
        }
        public async Task<TaskNoteListVm> Handle(GetTaskNoteListQuery request, CancellationToken cancellationToken)
        {
            var list = (await _repository.GetAll()).Select(n =>
                new TaskNoteElemVm
                {
                    Id = n.Id,
                    Title = n.Title
                }).ToList();

            var taskNoteVmList = new TaskNoteListVm { TaskNotes = list };

            return taskNoteVmList;
        }
    }
}
