using TaskManager.Domain;

namespace TaskManager.Application
{
    public interface ITaskNoteRepository
    {
        IEnumerable<TaskNote> GetTasks(Func<TaskNote, bool> condition, int count);
        TaskNote GetTask(int id);
        void CreateTask(TaskNote note);
        void UpdateTask(TaskNote note);
        TaskNote DeleteTask(int id);
    }
}
