using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Account
{
    public class IndexModel : PageModel
    {
        //[TempData]
        public string Message {  get; set; }
        public AccountSearchModel searchModel;
        public List<AccountViewModel> accounts;
        public SelectList Roles;

        public readonly IRoleApplication _roleApplication;
        public readonly IAccountApplication _accountApplication;

        public IndexModel(IRoleApplication roleApplication, IAccountApplication accountApplication)
        {
            _roleApplication = roleApplication;
            _accountApplication = accountApplication;
        }

        public void OnGet(AccountSearchModel searchModel)
        {
            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
            accounts = _accountApplication.Search(searchModel);
        }
    }
}
