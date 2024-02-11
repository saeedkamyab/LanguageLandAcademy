using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.Interface;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TermClass
{
    public class EditModel : PageModel
    {
        //public EditRole Command;
        public List<SelectListItem> PeopleList = new List<SelectListItem>();
        private readonly ITermClassApplication _termClassApp;
        private readonly IAccountApplication _accountApp;

        private readonly IEnumerable<IPermissionExposer> _exposers;

        public EditModel(ITermClassApplication termClassApp, IEnumerable<IPermissionExposer> exposers)
        {
            _termClassApp = termClassApp;

            _exposers = exposers;
        }

        [BindProperty]
        public EditTermClass TermClass { get; set; }
        public List<AccountViewModel> acc { get; set; }


        public void OnGet(int id)
        {
            TermClass = _termClassApp.GetDetails(id);
       
        }

        public IActionResult OnPost()
        {
            var result = _termClassApp.UpdateTermClass(TermClass);
            return RedirectToPage("Index");
        }
    }
}
