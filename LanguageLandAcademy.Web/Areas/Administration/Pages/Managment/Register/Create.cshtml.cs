using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Register
{
    public class CreateModel : PageModel
    {
        public AccountSearchModel searchModel;
       
        public List<AccountViewModel> accounts;

        public List<GetAllRegisteration> Registers { get; set; }

        public long tId;

        public readonly IAccountApplication _accountApplication;
        public readonly IRegisterInApplication _reApplication;

        public CreateModel(IAccountApplication accountApplication, IRegisterInApplication reApplication)
        {
            _accountApplication = accountApplication;
            _reApplication = reApplication;
        }
        [BindProperty]
        public AddRegisteration Registeration { get; set; }


        public void OnGet(long id, AccountSearchModel searchModel)
        {
            tId = id;
            Registers=_reApplication.GetAllReByTcId(id);
            accounts = _accountApplication.Search(searchModel);
        }

        public IActionResult OnPostAddToTerm()
        {
            var result = _reApplication.AddRegistration(Registeration);
            return RedirectToPage("./Create",new { Id= Registeration.TermClassId });
        }
        public IActionResult OnPostDeleteFromTerm(long id)
        {
            var result = _reApplication.PhysicalDeleteRegistration(id);
            return RedirectToPage("./Create", new { Id = Registeration.TermClassId });
        }
    }
}
