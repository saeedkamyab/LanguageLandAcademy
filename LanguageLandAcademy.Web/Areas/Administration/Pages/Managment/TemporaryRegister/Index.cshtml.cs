using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.TemporaryRegister.Interface;
using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TemporaryRegister
{
    public class IndexModel : PageModel
    {
        private readonly ITemporaryRegisterApplication _teRegisterApp;

        public IndexModel(ITemporaryRegisterApplication teRegisterApp)
        {
            _teRegisterApp = teRegisterApp;
        }

        //-----------Bind Property--------------------
        public List<AllTemporaryRegister> TeRegisterItems { get; set; }

        public void OnGet()
        {
            TeRegisterItems = _teRegisterApp.GetAllTeRegister();
        }
        public IActionResult OnPostDelete(int id)
        {
            _teRegisterApp.DeleteTeRegister(id);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostRestore(int id)
        {
            _teRegisterApp.RestoreTeRegister(id);
            return RedirectToPage("Index");
        }
    }
}
