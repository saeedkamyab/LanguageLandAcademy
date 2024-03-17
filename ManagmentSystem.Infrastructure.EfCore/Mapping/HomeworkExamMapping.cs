using ManagmentSystem.Domain.TuitionAgg;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentSystem.Domain.HomeworksExams;

namespace ManagmentSystem.Infrastructure.EfCore.Mapping
{
    public class HomeworkExamMapping : IEntityTypeConfiguration<HomeworkExam>
    {
        public void Configure(EntityTypeBuilder<HomeworkExam> builder)
        {
            builder.ToTable("HomeworkExams");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.CreateDate).IsRequired();
            builder.Property(t => t.Question).HasMaxLength(500).IsRequired();
            builder.Property(t => t.OptionA).HasMaxLength(200).IsRequired(false);
            builder.Property(t => t.OptionB).HasMaxLength(200).IsRequired(false);
            builder.Property(t => t.OptionC).HasMaxLength(200).IsRequired(false);
            builder.Property(t => t.OptionD).HasMaxLength(200).IsRequired(false);
            builder.Property(t => t.Session).IsRequired();
            builder.Property(t => t.CorrectAnswer).HasMaxLength(500);
            builder.Property(t => t.Description).IsRequired(false).HasMaxLength(300);
            builder.Property(t => t.IsRemoved);
            builder.Property(t => t.LastUpdate);

            builder.HasOne(x => x.Level)
               .WithMany(x => x.HomeworkExams)
               .HasForeignKey(x => x.LevelId);

        }
    }
}
