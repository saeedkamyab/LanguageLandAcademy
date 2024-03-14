using LLaQuery.Contracts.Account;
using Microsoft.AspNetCore.Mvc;


namespace AccountManagment.PresentaionApi
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccListController : ControllerBase
    {
        private readonly IAccountListQuery _accountListQuery;

        public AccListController(IAccountListQuery accountListQuery)
        {
            _accountListQuery = accountListQuery;
        }
        [HttpGet]
        public List<AccountListQueryModel> GetAccounts()
        {
            return _accountListQuery.AllAccounts();
        }
    }
}
