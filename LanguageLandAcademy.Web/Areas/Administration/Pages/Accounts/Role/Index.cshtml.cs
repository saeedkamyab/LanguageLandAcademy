using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Role
{
    public class IndexModel : PageModel
    {
        public List<RoleViewModel> roles;

        public readonly IRoleApplication _roleApplication;

        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public void OnGet()
        {
            roles = _roleApplication.List();
        }
    }
}
