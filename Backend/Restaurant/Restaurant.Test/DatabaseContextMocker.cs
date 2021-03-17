using Microsoft.EntityFrameworkCore;
using Restaurant.Infra.Data;
using System;

namespace Restaurant.Tests
{
    public static class DatabaseContextMocker
    {
        public static DataContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new DataContext(options);
            return context;
        }
    }
}
