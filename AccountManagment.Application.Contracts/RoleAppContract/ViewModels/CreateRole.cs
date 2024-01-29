namespace AccountManagment.Application.Contracts.RoleAppContract.ViewModels
{
    public class CreateRole
    {
        public string Name { get; set; }
        public List<int> Permissions { get; set; }
    }
}
