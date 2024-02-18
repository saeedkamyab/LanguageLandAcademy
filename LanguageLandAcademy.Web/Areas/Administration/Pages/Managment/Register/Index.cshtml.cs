using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Register
{
    public class IndexModel : PageModel
    {
        private readonly IRegisterInApplication _reApp;

        public IndexModel(IRegisterInApplication reApp)
        {
            _reApp = reApp;
        }
        public List<GetAllRegisteration> registerations { get; set; }
        public void OnGet()
        {
            registerations = _reApp.GetAllRegisteration();
        }
        public IActionResult OnPostDelete(int id)
        {
            _reApp.DeleteRegistration(id);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostRestore(int id)
        {
            _reApp.RestoreRegistration(id);
            return RedirectToPage("Index");
        }
    }
}
