using Microsoft.EntityFrameworkCore;
using TaskManager.Application;
using TaskManager.Domain;

namespace TaskManager.Infrastructure
{
    public class TaskNoteDbContext : DbContext, ITaskNoteRepository
    {
        protected string connectionString = "host=localhost;port=5432;database=tasks;username=task_manager;password=pass1234";
        public DbSet<TaskNote> Tasks => Set<TaskNote>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public void CreateTask(TaskNote note)
        {
            Tasks.Add(note);
            SaveChanges();
        }

        public TaskNote DeleteTask(int id)
        {
            var task = Tasks.SingleOrDefault(x => x.Id == id);
            if (!(task is null))
                Tasks.Remove(task);

            SaveChanges();

            return task;
        }

        public IEnumerable<TaskNote> GetTasks(Func<TaskNote, bool> condition, int count)
        {
            return Tasks.Where(condition).Take(count);
        }

        public TaskNote GetTask(int id)
        {
            var task = Tasks.SingleOrDefault(x => x.Id == id);

            return task;
        }

        public void UpdateTask(TaskNote note)
        {
            Tasks.Update(note);
            SaveChanges();
        }
    }
}
