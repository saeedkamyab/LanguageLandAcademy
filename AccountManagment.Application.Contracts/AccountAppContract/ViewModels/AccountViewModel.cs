namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class AccountViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string FName { get; set; }
        public string NationalCode { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string ProfilePhoto { get; set; }
        public string CreationDate { get; set; }
    }
}
