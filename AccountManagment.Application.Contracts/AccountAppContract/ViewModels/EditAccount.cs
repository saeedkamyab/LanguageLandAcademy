
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class EditAccount:RegisterAccount
    {
        public long Id { get; set; }
        public string? Password { get; set; }
        public string? RePassword { get; set; }
        public string? Address { get; set; }
        public IFormFile? ProfilePhoto { get; set; }
    }
}
