using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Level
{
    public class CreateModel : PageModel
    {
        private readonly ILevelApplication _levelApp;

        public CreateModel(ILevelApplication levelApp)
        {
            _levelApp = levelApp;
        }

        public void OnGet()
        {
        }
        [BindProperty]
        public AddLevelItem levelItem { get; set; }


        public IActionResult OnPost()
        {
            var result = _levelApp.AddLevel(levelItem);
            return RedirectToPage("Index");
        }
    }
}
