using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class RegisterAccount
    {
        [Required(ErrorMessage =ValidationMessages.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string UserName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string FName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string NationalCode { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public bool Gender { get; set; }
    
        public string Description { get; set; }

        public int RoleId { get; set; }
        public List<RoleViewModel> Roles { get; set; }

    }
}
