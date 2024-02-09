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
            builder.Property(t => t.Description);
            builder.Property(t => t.Day);
            builder.Property(t => t.LastUpdate);
            builder.Property(t => t.IsRemoved);


            builder.HasOne(x => x.Level)
            .WithMany(x => x.TermClasses)
            .HasForeignKey(x => x.LevelId);

            builder.HasOne(x => x.Room)
        .WithMany(x => x.TermClasses)
        .HasForeignKey(x => x.RoomId);


            builder.OwnsMany(t => t.PeopleLists, navigationBuilder =>
            {
                navigationBuilder.HasKey(t => t.PersonId);
                navigationBuilder.ToTable("StudentTermList");
                navigationBuilder.WithOwner(t => t.TermClass);
            });
        }
    }
}
