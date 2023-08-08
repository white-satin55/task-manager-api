using TaskManager.Application.Interfaces;
using TaskManager.Domain;
using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.CreateCommand
{
    public class CreateTaskNoteCommandHandler : IRequestHandler<CreateTaskNoteCommand, Guid>
    {
        private readonly IRepository<TaskNote> _repository;
        public CreateTaskNoteCommandHandler(IRepository<TaskNote> repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(CreateTaskNoteCommand request, CancellationToken cancellationToken)
        {
            var taskNote = new TaskNote
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                Deadline = request.Deadline,
                CreatedDate = DateTime.UtcNow
            };

            await _repository.Add(taskNote);
            await _repository.SaveChanges();

            return taskNote.Id;
        }
    }
}
