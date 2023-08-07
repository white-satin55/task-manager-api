

namespace TaskManager.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(TaskNoteDbContext dbContext)
        {            
            dbContext.Database.EnsureCreated();
        }
    }
}
