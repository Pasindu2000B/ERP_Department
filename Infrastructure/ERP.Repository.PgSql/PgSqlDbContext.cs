using ERP.Domain.Core.Entity;
using ERP.Repository.PgSql.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            
            modelBuilder.Entity<ModuleTeacher>()
            .HasKey(mt => new { mt.ModuleId, mt.TeacherId });

            modelBuilder.Entity<ModuleTeacher>()
                .HasOne(mt => mt.Module)
                .WithMany(mt => mt.Teachers)
                .HasForeignKey(mt => mt.ModuleId);

            modelBuilder.Entity<ModuleTeacher>()
                .HasOne(mt => mt.Teacher)
                .WithMany(mt => mt.TeachingModules)
                .HasForeignKey(mt => mt.TeacherId);


            modelBuilder.Entity<ModuleFirstExaminer>()
                .HasKey(mf => new {mf.ModuleId,mf.TeacherId});
            modelBuilder.Entity<ModuleFirstExaminer>()
                .HasOne(mf => mf.Module)
                .WithMany(mf => mf.FirstExaminers)
                .HasForeignKey(mf => mf.TeacherId);

            modelBuilder.Entity<ModuleFirstExaminer>()
                .HasOne(mf => mf.Teacher)
                .WithMany(mf => mf.FirstExaminersModules)
                .HasForeignKey(mf =>mf.TeacherId);


            modelBuilder.Entity<ModuleSecondExaminer>()
                .HasKey(ms => new { ms.ModuleId, ms.TeacherId });
            modelBuilder.Entity<ModuleSecondExaminer>()
                .HasOne(ms => ms.Module)
                .WithMany(ms => ms.SecondExaminers)
                .HasForeignKey(ms => ms.TeacherId);

            modelBuilder.Entity<ModuleSecondExaminer>()
                .HasOne(ms => ms.Teacher)
                .WithMany(ms => ms.SecondExaminersModules)
                .HasForeignKey(ms => ms.TeacherId);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ModuleTeacher> ModuleTeachers { get; set;}
        public DbSet<ModuleFirstExaminer> ModuleFirstExaminers { get; set; }
        public DbSet<ModuleSecondExaminer> ModuleSecondExaminers { get; set; }

    }
}
