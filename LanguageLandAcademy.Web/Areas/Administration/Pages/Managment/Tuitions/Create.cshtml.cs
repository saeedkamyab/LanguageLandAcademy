using ManagmentSystem.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Infrastructure;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.Tuitions
{
    public class CreateModel : PageModel
    {



        [NeedsPermission(ManagmentSystemPermissons.CreateTuition)]
        public void OnGet()
        {
        }
    }
}
