using Microsoft.EntityFrameworkCore;
using whatDo.Server.Models;

namespace whatDo.Server.Data.Contexts
{
    public class WhatDoDbContext : DbContext
    {
        public WhatDoDbContext(DbContextOptions<WhatDoDbContext> options) : base(options) { }
        public DbSet<ToDoItem> Tasks { get; set; }

    }
}
