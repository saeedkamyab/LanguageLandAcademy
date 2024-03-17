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
        private readonly ITuitionApplication _tuitionApp;
        public long StudentId { get; set; }

        public CreateModel(ITuitionApplication tuApp)
        {
            _tuitionApp = tuApp;
        }
        [BindProperty]
        public CreateRoom tuition { get; set; }

        [NeedsPermission(ManagmentSystemPermissons.CreateTuition)]
        public void OnGet(long studentid)
        {
            StudentId = studentid;
        }
        public JsonResult OnPost()
        {
            var result = _tuitionApp.CreateTuition(tuition);
            return new JsonResult(result);
        }
    }
}
