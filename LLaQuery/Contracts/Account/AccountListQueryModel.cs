using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLaQuery.Contracts.Account
{
    public class AccountListQueryModel
    {
        #region Properties

        public string FullName { get; set; }
        public string FName { get; set; }
        public string NationalCode { get; set; }
        public string ProfilePhoto { get; set; }
        public string Description { get; set; }

        ////Relation
        //public int RoleId { get; private set; }
        //public Role Role { get; private set; }
        #endregion
    }
}
