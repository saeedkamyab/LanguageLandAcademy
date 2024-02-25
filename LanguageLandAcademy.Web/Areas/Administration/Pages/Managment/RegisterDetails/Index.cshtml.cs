using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.RegisterDetails
{
    public class IndexModel : PageModel
    {
        public readonly IAccountApplication _accountApplication;
        public readonly IRegisterInApplication _reApplication;

        public IndexModel(IAccountApplication accountApplication, IRegisterInApplication reApplication)
        {
            _accountApplication = accountApplication;
            _reApplication = reApplication;
        }

        public List<AccountViewModel> accounts;
        public List<GetAllRegisteration> Registers { get; set; }

        [BindProperty]
        public EditRegisteration registeration { get; set; }


        public void OnGet(long id)
        {

                accounts = _accountApplication.GetAccounts();
                Registers = _reApplication.GetAllReByTcId(id);

        }
    }
}
