using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Account
{
    public class EditModel : PageModel
    {
        private readonly IRoleApplication _roleApplication;
        private readonly IAccountApplication _accountApplication;
        public SelectList Roles;
        public EditModel(IRoleApplication roleApplication, IAccountApplication accountApplication)
        {
            _roleApplication = roleApplication;
            _accountApplication = accountApplication;
        }


        [BindProperty]
        public EditAccount account { get; set; }
        public void OnGet(long id)
        {
            var account = _accountApplication.GetDetails(id);
            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
        }
    }
}
