using ManagmentSystem.Domain.TuitionAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class TuitionMapping:IEntityTypeConfiguration<Tuition>
    {
        public void Configure(EntityTypeBuilder<Tuition>builder)
        {
            builder.ToTable("Tuitions");
            builder.HasKey(t=>t.Id);

            builder.Property(t=>t.CreateDate).IsRequired();
            builder.Property(t=>t.TuitionAmount).IsRequired();
            builder.Property(t=>t.TuitionStatus).IsRequired();
            builder.Property(t=>t.TuitionPayDate);
            builder.Property(t=>t.TuitionDescription).IsRequired(false).HasMaxLength(300);
            builder.Property(t=>t.IsRemoved);
            builder.Property(t=>t.LastUpdate);



        }
    }
}
