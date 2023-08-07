using Microsoft.EntityFrameworkCore;
using TaskManager.Application;
using TaskManager.Domain;
using TaskManager.Infrastructure.Configurations;

namespace TaskManager.Infrastructure
{
    public class TaskNoteDbContext : DbContext
    {
        protected string connectionString = "host=localhost;port=5432;database=tasks;username=task_manager;password=pass1234";
        public DbSet<TaskNote> Tasks => Set<TaskNote>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskNoteConfiguration());
            base.OnModelCreating(modelBuilder);
        }        
    }
}
