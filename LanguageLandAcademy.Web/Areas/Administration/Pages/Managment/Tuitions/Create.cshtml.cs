using AccountManagment.Application.AccountApp;
using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg;
using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Tuitions
{
    public class CreateModel : PageModel
    {
        private readonly IAccountApplication _accountApp;
        private readonly ITuitionApplication _tuitionApp;

        public CreateModel(IAccountApplication accApp, ITuitionApplication tuApp)
        {
            _accountApp = accApp;
            _tuitionApp = tuApp;
        }
        [BindProperty]
        public CreateRoom tuition {  get; set; }
        public List<AccountViewModel> students {  get; set; }

        [NeedsPermission(ManagmentSystemPermissons.CreateTuition)]
        public void OnGet()
        {
           students = _accountApp.GetAccounts();
        }
        public JsonResult OnPost()
        {
            var result = _tuitionApp.CreateTuition(tuition);
            return new JsonResult(result);
        }
    }
}
