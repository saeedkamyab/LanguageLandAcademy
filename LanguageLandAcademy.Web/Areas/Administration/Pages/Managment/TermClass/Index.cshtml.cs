using ManagmentSystem.Application.Contract.TermClass.Interface;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TermClass
{
    public class IndexModel : PageModel
    {
        private readonly ITermClassApplication _tCApp;
        public IndexModel(ITermClassApplication tCApp)
        {
            _tCApp = tCApp;
        }
        public List<GetAllTermClassItems> termClasses;

        [NeedsPermission(ManagmentSystemPermissons.TuitionsList)]
        public void OnGet()
        {
            termClasses = _tCApp.GetAllTermClass();
        }
        //public IActionResult OnGetPay(long Id)
        //{
        //    _tuApp.PayTuition(Id);
        //    return RedirectToPage("./Index");
        //}
        public IActionResult OnGetRemove(long Id)
        {
            _tCApp.DeleteTermClass(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRestore(long Id)
        {
            _tCApp.RestoreTermClass(Id);
            return RedirectToPage("./Index");
        }
    }
}
