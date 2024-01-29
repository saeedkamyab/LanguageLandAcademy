using ZeroFramework.Infrastructure;

namespace AccountManagment.Application.Contracts.RoleAppContract.ViewModels
{
    public class EditRole:CreateRole
    {
        public int Id { get; set; }
        public List<PermissionDto> MappedPermissions { get; set; }

        public EditRole()
        {
            Permissions = new List<int>();
        }
    }
}
