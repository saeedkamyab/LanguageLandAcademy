using AccountManagment.Domain.AccountAgg;
using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Certificate
{
    public class CertificateModel : PageModel
    {
        private IRegisterInApplication _regApp;

        public CertificateModel(IRegisterInApplication regApp)
        {
            _regApp = regApp;
        }

        public long RegisterId { get; set; }
        [BindProperty]
        public EditRegisteration Register { get; set; }


        public void OnGet(long registerid)
        {
            RegisterId = registerid;
            Register = _regApp.GetRegistrationEditDetail(registerid);

        }
        [NeedsPermission(ManagmentSystemPermissons.EditRegister)]
        public IActionResult OnPostEdit()
        {
            var result = _regApp.EditRegistration(Register);
            if (result.IsSucceeded)
            {
                return RedirectToPage("/Accounts/Account/Index", null);
            }
            return RedirectToPage("./Edit", new { Register.Id });
        }
    }
}
