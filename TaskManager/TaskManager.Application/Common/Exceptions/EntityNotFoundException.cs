

namespace TaskManager.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public override string Message => "Entity not found";
    }
}
