using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.TemporaryRegister.Interface;
using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TemporaryRegister
{
    public class EditModel : PageModel
    {
        private readonly ITemporaryRegisterApplication _teRegister;

        public EditModel(ITemporaryRegisterApplication teRegister)
        {
            _teRegister = teRegister;
        }

        public void OnGet(int id)
        {
            teRegister = _teRegister.GetTeRegisterItemDetail(id);
        }
        [BindProperty]
        public EditTemporaryRegister teRegister { get; set; }
     
        public IActionResult OnPost()
        {
            var result = _teRegister.UpdateTeRegister(teRegister);
            return RedirectToPage("Index");
        }
    }
}
