﻿using AccountManagment.Application.AccountApp;
using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZeroFramework.Application.Common;

namespace LanguageLandAcademy.Web.Pages
{
    public class LoginModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set; }

        private readonly IAccountApplication _accApp;

        public LoginModel(IAccountApplication accApp)
        {
            _accApp = accApp;
        }

        public void OnGet(OperationResult res)
        {
            LoginMessage = res.Message;
        }

        [BindProperty]
        public Login login { get; set; }

        public IActionResult OnPostLogin()
        {
            //username : saeedkamyab  pass: 1234
            var result = _accApp.Login(login);
            if (result.IsSucceeded)
                return RedirectToPage("/Index", new { area = "Administration" });

            return RedirectToPage("/Login", result);
        }
        public IActionResult OnGetLogout()
        {
            _accApp.Logout();
            return RedirectToPage("/Index");
        }
    }
}
