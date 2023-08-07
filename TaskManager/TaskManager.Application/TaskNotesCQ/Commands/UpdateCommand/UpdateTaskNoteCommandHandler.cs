using TaskManager.Application;
using TaskManager.Application.Common.Exceptions;
using TaskManager.Domain;
using MediatR;

namespace TaskManager.Application.TaskNotesCQ.Commands.UpdateCommand
{
    public class UpdateTaskNoteCommandHandler : IRequestHandler<UpdateTaskNoteCommand, Guid>
    {
        private IRepository<TaskNote> _repository;


        public UpdateTaskNoteCommandHandler(IRepository<TaskNote> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(UpdateTaskNoteCommand request, CancellationToken cancellationToken)
        {
            TaskNote taskNote;
            try
            {
                taskNote = await _repository.GetById(request.Id);
            }
            catch (EntityNotFoundException ex)
            {

            }
        }
    }
}
