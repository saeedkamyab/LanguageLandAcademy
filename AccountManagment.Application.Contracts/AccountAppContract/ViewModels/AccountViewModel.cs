using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class AccountViewModel
    {
        public long Id { get; set; }
        public string Fullname { get; set; }
        public string UserName { get; set; }
        public string FName { get; set; }
        public string NationalCode { get; private set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public string ProfilePhoto { get; set; }
        public string CreationDate { get; set; }
    }
}
