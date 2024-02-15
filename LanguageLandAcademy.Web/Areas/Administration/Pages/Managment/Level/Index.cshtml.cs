using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Level
{
    public class IndexModel : PageModel
    {
        private readonly ILevelApplication _levelApp;

        public IndexModel(ILevelApplication levelApp)
        {
            _levelApp = levelApp;
        }

        //-----------Bind Property--------------------
        public List<GetAllLevelItems> levelItems { get; set; }

        public void OnGet()
        {
            levelItems = _levelApp.GetAllLevels();
        }
        public IActionResult OnPostDelete(int id)
        {
            _levelApp.DeleteLevel(id);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostRestore(int id)
        {
            _levelApp.RestoreLevel(id);
            return RedirectToPage("Index");
        }
    }
}
