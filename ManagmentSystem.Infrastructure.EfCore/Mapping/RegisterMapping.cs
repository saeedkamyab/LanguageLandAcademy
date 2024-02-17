using ManagmentSystem.Domain.RegisterInAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class RegisterMapping : IEntityTypeConfiguration<Register>
    {
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder.ToTable("TermClass");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.PeopleId);
            builder.Property(t => t.Reading);
            builder.Property(t => t.Writting);
            builder.Property(t => t.Listening);
            builder.Property(t => t.Speaking);
            builder.Property(t => t.MidTerm);
            builder.Property(t => t.Final);
            builder.Property(t => t.CreateDate);
            builder.Property(t => t.LastUpdate);
            builder.Property(t => t.Description);
            builder.Property(t => t.IsRemoved);


            builder.HasOne(x => x.TermClass)
                .WithMany(x => x.Registers)
                .HasForeignKey(x => x.TermClassId);
        }
    }
}
