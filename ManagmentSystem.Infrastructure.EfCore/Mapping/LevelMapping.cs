using ManagmentSystem.Domain.LevelAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class LevelMapping : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.ToTable("Level");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.LevelName).IsRequired().HasMaxLength(150);
            builder.Property(x=>x.LevelType);
            builder.Property(x=>x.LevelDescription).IsRequired(false).HasMaxLength(300);
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.IsRemoved);

            builder.HasMany(x=>x.TermClasses).WithOne(x => x.Level).HasForeignKey(x=>x.Id);
        }
    }
}
