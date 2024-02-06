using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Tuitions
{
    public class IndexModel : PageModel
    {
        private readonly ITuitionApplication _tuApp;

        public IndexModel(ITuitionApplication tuApp)
        {
            _tuApp = tuApp;
        }
        public List<AllTuitions> tuitions;

        [NeedsPermission(ManagmentSystemPermissons.TuitionsList)]
        public void OnGet()
        {
            tuitions = _tuApp.GetAllTuitions();
        }
        public IActionResult OnGetPay(long Id)
        {
            _tuApp.PayTuition(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRemove(long Id)
        {
            _tuApp.RemoveTuition(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRestore(long Id)
        { 
        _tuApp.RestoreTuition(Id);
            return RedirectToPage("./Index");
        }
    }
}
