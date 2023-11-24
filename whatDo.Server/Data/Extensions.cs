using whatDo.Server.Data.Contexts;

namespace whatDo.Server.Data
{
    public static class Extensions
    {
        public static void CreateDbIfNotExists(this IHost host)
        {
            {
                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<WhatDoDbContext>();
                    context.Database.EnsureCreated();
                    DbInitializer.Initialize(context);
                }
            }
        }
    }
}
