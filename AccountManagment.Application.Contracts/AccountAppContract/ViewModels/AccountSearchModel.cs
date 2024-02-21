using System.ComponentModel.DataAnnotations;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class AccountSearchModel
    {
        [Required(ErrorMessage ="برای جستجو باید نام را وارد نمایید")]
        public string Fullname { get; set; }

        public string Username { get; set; }

        public int    RoleId { get; set; }
    }
}