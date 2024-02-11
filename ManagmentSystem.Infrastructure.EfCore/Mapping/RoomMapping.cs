using ManagmentSystem.Domain.RoomAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class RoomMapping : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoomName).IsRequired().HasMaxLength(150); ;
            builder.Property(x => x.Descriptions).IsRequired(false).HasMaxLength(300); ;
            builder.Property(x => x.CreateDate);
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.IsRemoved);

            builder.HasMany(x => x.TermClasses).WithOne(x => x.Room).HasForeignKey(x => x.Id);
        }
    }
}
