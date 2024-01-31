using AccountManagment.Application.AccountApp;
using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Application.Common;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages
{
    public class LoginModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set; }

        private readonly IAccountApplication _accApp;

        public LoginModel(IAccountApplication accApp)
        {
            _accApp = accApp;
        }

        public void OnGet(OperationResult res)
        {
            LoginMessage = res.Message;
        }

        [BindProperty]
        public Login login { get; set; }

        public IActionResult OnPostLogin()
        {
            var result = _accApp.Login(login);
            if (result.IsSucceeded)
                return RedirectToPage("/Index");

            return RedirectToPage("/Login", result);
        }

    }
}
