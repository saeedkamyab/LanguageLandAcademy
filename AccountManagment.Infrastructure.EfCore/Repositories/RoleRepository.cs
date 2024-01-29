using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Domain.RoleAgg.Interface;
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
        private static List<PermissionDto> MapPermissions(IEnumerable<Permission> permissions)
        {
            return permissions.Select(x => new PermissionDto(x.Code, x.Name)).ToList();
        }
        public List<RoleViewModel> List()
        {
            return _acMaContext.Roles.Select(x => new RoleViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
