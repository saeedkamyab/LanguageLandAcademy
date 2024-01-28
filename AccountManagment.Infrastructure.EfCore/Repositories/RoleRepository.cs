using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Domain.RoleAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace AccountManagment.Infrastructure.EfCore.Repositories
{
    public class RoleRepository : RepositoryBase<int, Role>, IRoleRepository
    {
        private readonly AccountManagmentContext _acMaContext;

        public RoleRepository(AccountManagmentContext acMaContext):base(acMaContext) 
        {
            _acMaContext = acMaContext;
        }

        public EditRole GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<RoleViewModel> List()
        {
            throw new NotImplementedException();
        }
    }
}
