using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Configuration.Permissions;
using ManagmentSystem.Domain.TuitionAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using System.Drawing;
using System;
using System.Linq;
using ZeroFramework.Infrastructure;
using ZeroFramework.Application.Common;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Managment.TermClass
{
    public class IndexModel : PageModel
    {
        private readonly ITuitionApplication _tuApp;
        public IndexModel(ITuitionApplication tuApp)
        {
            _tuApp = tuApp;
        }
        public List<AllTuitions> tuitions;

        [NeedsPermission(ManagmentSystemPermissons.TuitionsList)]
        public void OnGet()
        {
            tuitions = _tuApp.GetAllTuitions();
        }
        public IActionResult OnGetPay(long Id)
        {
            _tuApp.PayTuition(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRemove(long Id)
        {
            _tuApp.RemoveTuition(Id);
            return RedirectToPage("./Index");
        }
        public IActionResult OnGetRestore(long Id)
        {
            _tuApp.RestoreTuition(Id);
            return RedirectToPage("./Index");
        }
    }
}
