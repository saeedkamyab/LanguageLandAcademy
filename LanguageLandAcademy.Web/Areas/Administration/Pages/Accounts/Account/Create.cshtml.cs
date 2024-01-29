using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Account
{
    public class CreateModel : PageModel
    {
        public SelectList Roles;
        public readonly IRoleApplication _roleApplication;
        public readonly IAccountApplication _accountApplication;

        public CreateModel(IRoleApplication roleApplication, IAccountApplication accountApplication)
        {
            _roleApplication = roleApplication;
            _accountApplication = accountApplication;
        }

        [BindProperty]
        public RegisterAccount account { get; set; }
 
        public void OnGet()
        {
            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
        }

        public JsonResult OnPost()
        {
            var result = _accountApplication.Register(account);
            return new JsonResult(result);
        }
    }
}
