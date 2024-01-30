using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Domain.RoleAgg.Interface;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.RoleApp
{
    public class RoleApplication : IRoleApplication
    {

        private readonly IRoleRepository _roleRepo;

        public RoleApplication(IRoleRepository roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public OperationResult Create(CreateRole command)
        {
            OperationResult result = new OperationResult();

            if (_roleRepo.Exists(x => x.Name == command.Name))
                return result.Failed(ApplicationMessages.DuplicatedRecord);

            var role = new Role(command.Name, new List<Permission>());
            _roleRepo.Create(role);
            _roleRepo.SaveChanges();


            return result.Succeeded();
        }

        public OperationResult Edit(EditRole command)
        {
            OperationResult result = new OperationResult();
            var role = _roleRepo.Get(command.Id);
            if (role == null)
                return result.Failed(ApplicationMessages.RecordNotFound);

            var permissions = new List<Permission>();
            command.Permissions.ForEach(code => permissions.Add(new Permission(code)));
             role.Edit(command.Name, permissions);
            _roleRepo.SaveChanges();
            return result.Succeeded();
        }

        public EditRole GetDetails(int id)
        {
           return _roleRepo.GetDetails(id);
        }

        public List<RoleViewModel> List()
        {
            return _roleRepo.List();
        }
    }
}
