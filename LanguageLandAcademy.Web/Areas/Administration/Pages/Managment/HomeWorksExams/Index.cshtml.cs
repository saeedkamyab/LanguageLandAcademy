using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.HomeWorksExams
{
    public class IndexModel : PageModel
    {
        public int LevelId { get; set; }

        public void OnGet(int levelId)
        {
            LevelId = levelId;
        }
    }
}
