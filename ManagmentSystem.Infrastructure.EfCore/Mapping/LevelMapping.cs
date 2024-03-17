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
            builder.ToTable("Levels");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x=>x.Type);
            builder.Property(x=>x.Fee);
            builder.Property(x=>x.Description).IsRequired(false).HasMaxLength(300);
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.IsRemoved);

            builder.HasMany(x=>x.TermClasses).WithOne(x => x.Level).HasForeignKey(x=>x.Id);
            builder.HasMany(x=>x.HomeworkExams).WithOne(x => x.Level).HasForeignKey(x=>x.Id);
        }
    }
}
