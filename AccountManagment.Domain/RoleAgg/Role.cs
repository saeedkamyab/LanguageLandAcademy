using AccountManagment.Domain.AccountAgg;
using ZeroFramework.Domain;

namespace AccountManagment.Domain.RoleAgg
{
    public class Role:EntityBase<int>
    {
        public string Name { get; private set; }
        public List<Permission> Permissions { get; private set; }
        public List<Account> Accounts { get; private set; }
        protected Role()
        {
        }

        public Role(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
            Accounts = new List<Account>();
        }

        public void Edit(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }
    }
}
