using WhatDo.Domain;

namespace Persistence
{
    public class DbInitializer
    {
        public static void Initialize(WhatDoDbContext context)
        {
            if (context.ToDoItems.Any()) return;
            var toDoItems = new ToDoItem[]
            {
                new ToDoItem
                {
                    Name = "work on the security feature",
                    Description = "add extra security to the login screen",
                    DueDate = new DateTime(2027, 10, 24),
                    IsCompleted = false
                },
                new ToDoItem
                {
                    Name = "write unit tests",
                    Description = "write tests for the implemented features",
                    DueDate = new DateTime(2020, 4, 15),
                    IsCompleted = true
                },
                new ToDoItem
                {
                    Name = "attend seminar",
                    Description = "go to the AI seminar and present your research",
                    DueDate = new DateTime(2019, 11, 3),
                    IsCompleted = false
                }
            };
            context.ToDoItems.AddRange(toDoItems);
            context.SaveChanges();
        }
    }
}
