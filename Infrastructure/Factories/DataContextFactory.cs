using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Factories;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{

    public DataContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<DataContext>();
        optionBuilder.UseSqlite("Data Source=Data/local_database.db");
        optionBuilder.UseSqlite("Data Source=Data/api_database.db");

        return new DataContext(optionBuilder.Options);
    }
    

}
