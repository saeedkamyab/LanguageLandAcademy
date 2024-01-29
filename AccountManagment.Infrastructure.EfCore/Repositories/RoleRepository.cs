using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Domain.RoleAgg.Interface;
using Microsoft.EntityFrameworkCore;
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

        public EditRole GetDetails(int id)
        {
            var role = _acMaContext.Roles.Select(x => new EditRole
            {
                Id=x.Id,
                Name=x.Name,
                MappedPermissions=MapPermissions(x.Permissions)
            }).AsNoTracking().FirstOrDefault(x=>x.Id==id);
            role.Permissions = role.MappedPermissions.Select(x => x.Code).ToList();

            return role;
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
