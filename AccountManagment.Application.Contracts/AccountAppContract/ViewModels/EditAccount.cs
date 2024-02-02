
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class EditAccount : RegisterAccount
    {
        /// <summary>
        ///    I made some of the properties nullable because
        ///    I don't want users to have to fill them 
        /// </summary>

        public long    Id { get; set; }

        public string? Password { get; set; }

        public string? RePassword { get; set; }

        public string? Address { get; set; }

        public IFormFile? ProfilePhoto { get; set; }
    }
}
