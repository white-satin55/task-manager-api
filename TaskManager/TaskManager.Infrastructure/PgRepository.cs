using TaskManager.Application.Interfaces;
using TaskManager.Domain;

namespace TaskManager.Infrastructure
{
    public class PgRepository : IRepository<TaskNote>
    {
        private TaskNoteDbContext _dbContext;
        public async Task Add(TaskNote entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public async Task<IEnumerable<TaskNote>> GetAll()
        {
            return _dbContext.Tasks.ToList();
        }

        public async Task<TaskNote> GetById(Guid id)
        {
            return _dbContext.Tasks.First(n => n.Id == id);
        }

        public async Task<TaskNote> Remove(Guid id)
        {
            var detelingTask = await GetById(id);
            _dbContext.Remove(detelingTask);

            return detelingTask;
        }
        public async Task Update(TaskNote entity)
        {
            await Remove(entity.Id);
            await Add(entity);
        }
        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }        
    }
}
