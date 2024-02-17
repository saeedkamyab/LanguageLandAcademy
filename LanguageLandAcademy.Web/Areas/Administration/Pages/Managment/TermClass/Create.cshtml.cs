using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.Interface;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Role
{
    public class CreateModel : PageModel
    {
        private readonly ITermClassApplication _tcApplication;
        private readonly ILevelApplication _lApplication;

        public CreateModel(ITermClassApplication tcApplication,
           ILevelApplication lApplication)
        {
            _tcApplication = tcApplication;
         
            _lApplication = lApplication;
        }
        [BindProperty]
        public CreateTermClass CreateTermClass { get; set; }
        public List<GetAllLevelItems> Levels { get; set; }

        [NeedsPermission(ManagmentSystemPermissons.CreateTermClass)]
        public void OnGet()
        {
        
            Levels = _lApplication.GetUnDeletedLevels().ToList();
        }

        public IActionResult OnPost()
        {
            var result = _tcApplication.CreateTermClass(CreateTermClass);
            return RedirectToPage("Index");
        }
    }
}