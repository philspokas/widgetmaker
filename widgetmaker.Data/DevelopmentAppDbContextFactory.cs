using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace widgetmaker.Data;

public class DevelopmentAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        // This is only used when adding migrations and updating the database from the cmd line.
        // It shouldn't ever be used in code where it might end up running in production.
        var builder = new DbContextOptionsBuilder<AppDbContext>();
        builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=widgetmaker;Trusted_Connection=True;TrustServerCertificate=True;");
        return new AppDbContext(builder.Options);
    }
}
