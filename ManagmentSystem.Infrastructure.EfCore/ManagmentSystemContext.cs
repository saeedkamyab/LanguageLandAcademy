using ManagmentSystem.Domain.HomeworksExams;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.PresentAbsentAgg;
using ManagmentSystem.Domain.RegisterInAgg;
using ManagmentSystem.Domain.TemporaryRegisterAgg;
using ManagmentSystem.Domain.TermClassAgg;
using ManagmentSystem.Domain.TuitionAgg;
using ManagmentSystem.Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ManagmentSystem.Infrastructure.EfCore
{
    public class ManagmentSystemContext:DbContext
    {
        public DbSet<Level> Levels { get; set; }

        public DbSet<TemporaryRegister> TemporaryRegisters { get; set; }

        public DbSet<AbsentPresent> AbsentPresents { get; set; }

        public DbSet<TermClass> TermClasses { get; set; }

        public DbSet<Register> Registers { get; set; }

        public DbSet<Tuition> Tuitions { get; set; }

        public DbSet<HomeworkExam> HomeworkExams { get; set; }

      

        public ManagmentSystemContext(DbContextOptions<ManagmentSystemContext>options):base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(TuitionMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
