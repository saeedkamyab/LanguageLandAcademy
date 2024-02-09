using ManagmentSystem.Domain.TemporaryRegisterAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class TemporaryRegisterMapping : IEntityTypeConfiguration<TemporaryRegister>
    {
        public void Configure(EntityTypeBuilder<TemporaryRegister> builder)
        {
            builder.ToTable("TemporaryRegister");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PhoneNumbers).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(300);
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.IsRemoved);

        }
    }
}
