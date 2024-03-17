using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Application.Contracts.RoleAppContract.Interface;
using LanguageLandAcademy.Web.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZeroFramework.Application.Common;

namespace LanguageLandAcademy.Web.Areas.Administration.Pages.Accounts.Account
{
    [Authorize]
    public class IndexModel : PageModel
    {

        public AccountSearchModel searchModel;

        public List<AccountViewModel> accounts;

        public SelectList Roles;

        public readonly IRoleApplication _roleApplication;
        public readonly IAccountApplication _accountApplication;

        public IndexModel(IRoleApplication roleApplication, IAccountApplication accountApplication)
        {
            _roleApplication = roleApplication;
            _accountApplication = accountApplication;
        }

        public void OnGet(AccountSearchModel searchModel, int pageindex)
        {

            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
           

            searchModel.PageSize = 10;

            if (pageindex == 0)
                searchModel.PageIndex = 1;
            else
                searchModel.PageIndex = pageindex;

            accounts = _accountApplication.Search(searchModel);


        }
    }
}
