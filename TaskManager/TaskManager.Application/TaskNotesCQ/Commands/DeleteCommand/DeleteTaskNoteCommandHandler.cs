using MediatR;
using TaskManager.Application.Common.Exceptions;
using TaskManager.Application.Interfaces;
using TaskManager.Domain;

namespace TaskManager.Application.TaskNotesCQ.Commands.DeleteCommand
{
    public class DeleteTaskNoteCommandHandler : IRequestHandler<DeleteTaskNoteCommand, Unit>
    {
        private IRepository<TaskNote> _repository;
        private ILogger _logger;

        public DeleteTaskNoteCommandHandler(IRepository<TaskNote> repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteTaskNoteCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.Remove(request.Id);
            }            
            catch (EntityNotFoundException ex)
            {
                _logger.Log(ex.Message);
                throw;
            }
            await _repository.SaveChanges();

            return Unit.Value;
        }
    }
}
