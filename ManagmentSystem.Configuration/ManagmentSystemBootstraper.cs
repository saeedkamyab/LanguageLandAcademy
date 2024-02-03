using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.TuitionApp;
using ManagmentSystem.Configuration.Permissions;
using ManagmentSystem.Domain.TuitionAgg.Interface;
using ManagmentSystem.Infrastructure.EfCore;
using ManagmentSystem.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Configuration
{
    public class ManagmentSystemBootstraper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ITuitionApplication, TuitionApplication>();
            services.AddTransient<ITuitionRepository, TuitionRepository>();

            services.AddTransient<IPermissionExposer,ManagmentSystemExposer>();

            services.AddDbContext<ManagmentSystemContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
