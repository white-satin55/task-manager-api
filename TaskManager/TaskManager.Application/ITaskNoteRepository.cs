using TaskManager.Domain;

namespace TaskManager.Application
{
    public interface ITaskNoteRepository
    {
        ICollection<TaskNote> GetAllTasks();
        TaskNote GetTask(int id);
        void CreateTask(TaskNote note);
        void UpdateTask(TaskNote note);
        TaskNote DeleteTask(int id);
    }
}
