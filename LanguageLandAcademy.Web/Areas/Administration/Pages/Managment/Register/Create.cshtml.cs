using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using Azure;
using Azure.Core;
using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Register
{
    public class CreateModel : PageModel
    {
        public readonly IAccountApplication _accountApplication;
        public readonly IRegisterInApplication _reApplication;

        public CreateModel(IAccountApplication accountApplication, IRegisterInApplication reApplication)
        {
            _accountApplication = accountApplication;
            _reApplication = reApplication;
        }
        public AccountSearchModel searchModel;

        public List<AccountViewModel> accounts;

        public List<AccountViewModel> searchResult;

        public List<GetAllRegisteration> Registers { get; set; }

        public long tId;
       
        //[BindProperty]
        //public long teId { get; set; }
       
        [BindProperty]
        public AddRegisteration registration { get; set; }


        public void OnGet(long id, AccountSearchModel searchModel)
        {
            
            if(searchModel.Fullname == null)
            {
                tId = id;
                accounts = _accountApplication.GetAccounts();
                searchResult = accounts;
                Registers = _reApplication.GetAllReByTcId(id);
            }
            else
            {
                tId =Convert.ToInt64(Request.Query["tId"]);

                accounts = _accountApplication.GetAccounts();

                searchResult = _accountApplication.Search(searchModel);
            }
            Registers = _reApplication.GetAllReByTcId(tId);

        }
        //Create? tId = 3 & searchModel.Fullname = معصومه + رحیمی

        public IActionResult OnPostAddToTerm()
        {
            var result = _reApplication.AddRegistration(registration);
            return RedirectToPage("./Create", new { Id = registration.TermClassId });
        }
        public IActionResult OnPostDeleteFromTerm(long id)
        {
            var result = _reApplication.PhysicalDeleteRegistration(id);
            return RedirectToPage("./Create", new { Id = registration.TermClassId });
        }
    }
}
