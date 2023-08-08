using TaskManager.Application.Interfaces;
using TaskManager.Application.Common.Exceptions;
using TaskManager.Domain;
using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.UpdateCommand
{
    public class UpdateTaskNoteCommandHandler : IRequestHandler<UpdateTaskNoteCommand, Unit>
    {
        private IRepository<TaskNote> _repository;
        private ILogger _logger;

        public UpdateTaskNoteCommandHandler(IRepository<TaskNote> repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateTaskNoteCommand request, CancellationToken cancellationToken)
        {
            TaskNote taskNote;
            try
            {
                taskNote = await _repository.GetById(request.Id);
            }
            catch (EntityNotFoundException ex)
            {
                _logger.Log(ex.Message);
                throw;
            }

            taskNote.Id = request.Id;
            taskNote.Title = request.Title;
            taskNote.Description = request.Description;
            taskNote.Deadline = request.Deadline;

            await _repository.Update(taskNote);
            await _repository.SaveChanges();

            return Unit.Value;
        }        
    }
}
