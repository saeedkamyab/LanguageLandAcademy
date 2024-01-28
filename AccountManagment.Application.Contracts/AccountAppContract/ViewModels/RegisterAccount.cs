using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class RegisterAccount
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string NationalCode { get; set; }
        public bool Gender { get; set; }
    
        public string Description { get; set; }

        public int RoleId { get; set; }


    }
}
