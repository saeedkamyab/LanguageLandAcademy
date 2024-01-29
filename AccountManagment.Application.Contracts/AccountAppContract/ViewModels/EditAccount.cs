
using Microsoft.AspNetCore.Http;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class EditAccount:RegisterAccount
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
}
