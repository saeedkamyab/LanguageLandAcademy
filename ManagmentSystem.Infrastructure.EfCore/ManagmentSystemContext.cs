using ManagmentSystem.Domain.TuitionAgg;
using ManagmentSystem.Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore
{
    public class ManagmentSystemContext:DbContext
    {
        public DbSet<Tuition> Tuitions { get; set; }

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
