using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.PresentAbsentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class AbsentPresentMapping : IEntityTypeConfiguration<AbsentPresent>
    {
        public void Configure(EntityTypeBuilder<AbsentPresent> builder)
        {
            builder.ToTable("AbsentPresents");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Status);
            builder.Property(x => x.DayDate);
            builder.Property(x=>x.Description).IsRequired(false).HasMaxLength(300);
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.IsRemoved);


            builder.HasOne(x => x.Register)
              .WithMany(x => x.absentPresent)
              .HasForeignKey(x => x.RegisterId);
        }
    }
}
