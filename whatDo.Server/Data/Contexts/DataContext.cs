using Microsoft.EntityFrameworkCore;
using whatDo.Server.Models;

namespace whatDo.Server.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<ToDoItem> Tasks { get; set; }

    }
}
