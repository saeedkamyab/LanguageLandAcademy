using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Level
{
    public class EditModel : PageModel
    {
        private readonly ILevelApplication _levelApp;

        public EditModel(ILevelApplication levelApp)
        {
            _levelApp = levelApp;
        }

        public void OnGet(int id)
        {
            levelItemE=_levelApp.GetLevelItemDetail(id);
        }
        [BindProperty]
        public EditLevelItem levelItemE { get; set; }
     
        public IActionResult OnPost()
        {
            var result = _levelApp.EditLevel(levelItemE);
            return RedirectToPage("Index");
        }
    }
}
