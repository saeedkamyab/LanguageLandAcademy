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

            builder.Property(t=>t.CreateDate);
            builder.Property(t=>t.TuitionAmount);
            builder.Property(t=>t.TuitionStatus);
            builder.Property(t=>t.TuitionPayDate);
            builder.Property(t=>t.TuitionDescription);
            builder.Property(t=>t.IsRemoved);
            builder.Property(t=>t.LastUpdate);



        }
    }
}
