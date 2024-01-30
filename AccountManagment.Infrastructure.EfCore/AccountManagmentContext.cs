using AccountManagment.Domain.AccountAgg;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagment.Infrastructure.EfCore
{
    public class AccountManagmentContext : DbContext
    {
        public AccountManagmentContext(DbContextOptions<AccountManagmentContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var assembly = typeof(AccountMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
