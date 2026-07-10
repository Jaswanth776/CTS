using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DTOsDemo.Data;

namespace DTOsDemo;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddUserSecrets<Program>()
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection")!;
        var password = configuration["Database:Password"]!;

        connectionString = connectionString.Replace("{PASSWORD}", password);

        return new ApplicationDbContext(connectionString);
    }
}
