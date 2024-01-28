using AccountManagment.Application.AccountApp;
using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.RoleApp;
using AccountManagment.Domain.AccountAgg.Interface;
using AccountManagment.Domain.RoleAgg.Interface;
using AccountManagment.Infrastructure.EfCore;
using AccountManagment.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagment.Configuration
{
    public class AccountManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IAccountApplication, AccountApplication>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<IRoleApplication, RoleApplication>();
            services.AddTransient<IRoleRepository, RoleRepository>();

            services.AddDbContext<AccountManagmentContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
