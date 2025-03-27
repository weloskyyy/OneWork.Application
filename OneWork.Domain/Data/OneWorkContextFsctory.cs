using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OneWork.Domain.Data
{
    public class OneWorkContextFactory : IDesignTimeDbContextFactory<OneWorkContext>
    {
        public OneWorkContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OneWorkContext>();


            optionsBuilder.UseSqlServer("Server=WELOSKKYY;Database=OneWorkDB;Trusted_Connection=True;TrustServerCertificate=True;");


            return new OneWorkContext(optionsBuilder.Options);
        }
    }
}
