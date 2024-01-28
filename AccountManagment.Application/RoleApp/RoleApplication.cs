using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.RoleAgg;
using AccountManagment.Domain.RoleAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
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
