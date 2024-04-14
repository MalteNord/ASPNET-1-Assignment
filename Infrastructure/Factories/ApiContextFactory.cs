using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Factories;

public class ApiContextFactory : IDesignTimeDbContextFactory<ApiContext>
{
    public ApiContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<ApiContext>();
        optionBuilder.UseSqlite("Data Source=Data/api_database.db");

        return new ApiContext(optionBuilder.Options);
    }
}
