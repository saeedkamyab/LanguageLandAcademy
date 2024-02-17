using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.TemporaryRegister.Interface;
using ManagmentSystem.Application.Contract.TermClass.Interface;
using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.LevelApp;
using ManagmentSystem.Application.TemporaryRegisterApp;
using ManagmentSystem.Application.TermClassApp;
using ManagmentSystem.Application.TuitionApp;
using ManagmentSystem.Configuration.Permissions;
using ManagmentSystem.Domain.LevelAgg.Interface;
using ManagmentSystem.Domain.TemporaryRegisterAgg.Interface;
using ManagmentSystem.Domain.TermClassAgg.Interface;
using ManagmentSystem.Domain.TuitionAgg.Interface;
using ManagmentSystem.Infrastructure.EfCore;
using ManagmentSystem.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

            services.AddTransient<ITermClassApplication, TermClassApplication>();
            services.AddTransient<ITermClassRepository, TermClassRepository>();

            services.AddTransient<ILevelApplication, LevelApplication>();
            services.AddTransient<ILevelRepository, LevelRepository>();

            services.AddTransient<ITemporaryRegisterApplication, TemporaryRegisterApplication>();
            services.AddTransient<ITemporaryRegisterRepository, TemporaryRegisterRepository>();


            services.AddDbContext<ManagmentSystemContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
