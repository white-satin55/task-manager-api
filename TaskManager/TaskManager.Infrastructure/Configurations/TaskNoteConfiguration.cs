using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Domain;

namespace TaskManager.Infrastructure.Configurations
{
    public class TaskNoteConfiguration : IEntityTypeConfiguration<TaskNote>
    {
        public void Configure(EntityTypeBuilder<TaskNote> builder)
        {
            
        }
    }
}
