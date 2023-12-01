
using Microsoft.EntityFrameworkCore;
using WhatDo.Domain;

namespace Persistence
{
    public class WhatDoDbContext : DbContext
    {
        public WhatDoDbContext(DbContextOptions<WhatDoDbContext> options) : base(options) { }
        public DbSet<ToDoItem> ToDoItems { get; set; }

    }
}
