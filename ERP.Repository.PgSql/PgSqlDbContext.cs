using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
    }
}
