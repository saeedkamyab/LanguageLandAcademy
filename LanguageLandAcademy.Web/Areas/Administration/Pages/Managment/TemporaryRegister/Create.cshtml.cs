using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.TemporaryRegister.Interface;
using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TemporaryRegister
{
    public class CreateModel : PageModel
    {
        private readonly ITemporaryRegisterApplication _teRegister;

        public CreateModel(ITemporaryRegisterApplication teRegister)
        {
            _teRegister = teRegister;
        }

        public void OnGet()
        {
        }
        [BindProperty]
        public CreateTemporaryRegister teRegister { get; set; }


        public IActionResult OnPost()
        {
            var result = _teRegister.CreateTeRegister(teRegister);
            return RedirectToPage("Index");
        }
    }
}
