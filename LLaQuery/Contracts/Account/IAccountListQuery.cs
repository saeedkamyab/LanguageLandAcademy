using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLaQuery.Contracts.Account
{
    public interface IAccountListQuery
    {
        List<AccountListQueryModel> AllAccounts();
    }
}
