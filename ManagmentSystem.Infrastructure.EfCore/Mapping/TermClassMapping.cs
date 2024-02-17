using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.TermClassAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class TermClassMapping : IEntityTypeConfiguration<TermClass>
    {
        public void Configure(EntityTypeBuilder<TermClass> builder)
        {
            builder.ToTable("TermClass");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.StartTime);
            builder.Property(t => t.EndTime);
            builder.Property(t => t.CreateDate);
            builder.Property(t => t.Room);
            builder.Property(t => t.Description);
            builder.Property(t => t.StartDate);
            builder.Property(t => t.EndDate);
            builder.Property(t => t.Status);
            builder.Property(t => t.Day);
            builder.Property(t => t.LastUpdate);
            builder.Property(t => t.IsRemoved);

            builder.HasOne(x => x.Level)
                .WithMany(x => x.TermClasses)
                .HasForeignKey(x => x.LevelId);

            builder.HasMany(x => x.Registers)
                .WithOne(x => x.TermClass)
                .HasForeignKey(x=>x.TermClassId);
        
        }
    }
}
