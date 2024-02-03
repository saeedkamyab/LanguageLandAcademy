using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Role
{
    public class CreateModel : PageModel
    {
        public readonly IRoleApplication _roleApplication;

        public CreateModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        [BindProperty]
        public CreateRole Role { get; set; }
        public void OnGet()
        {
        }
        public JsonResult OnPost()
        {
            var result = _roleApplication.Create(Role);
            return new JsonResult(result);
        }
    }
}
