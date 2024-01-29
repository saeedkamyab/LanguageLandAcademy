using AccountManagment.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagment.Infrastructure.EfCore.Mapping
{
    public class AccountMapping:IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.FullName).HasMaxLength(100).IsRequired();

            builder.Property(x=>x.UserName).HasMaxLength(100).IsRequired();

            builder.Property(x=>x.Password).HasMaxLength(1000).IsRequired();

            builder.Property(x=>x.FName).HasMaxLength(100).IsRequired();

            builder.Property(x=>x.NationalCode).HasMaxLength(10).IsRequired();

            builder.Property(x=>x.Gender).IsRequired();

            builder.Property(x=>x.Address).HasMaxLength(250).IsRequired(false);

            builder.Property(x=>x.ProfilePhoto).HasMaxLength(500).IsRequired(false);

            builder.Property(x=>x.Description).HasMaxLength(1000).IsRequired(false);

            builder.HasOne(x=>x.Role).WithMany(x=>x.Accounts).HasForeignKey(x=>x.RoleId);
   
        }
    }
}
