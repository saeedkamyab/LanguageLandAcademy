using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagment.Application.Contracts.AccountAppContract.ViewModels
{
    public class AccountSearchModel
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public long RoleId { get; set; }
    }
}