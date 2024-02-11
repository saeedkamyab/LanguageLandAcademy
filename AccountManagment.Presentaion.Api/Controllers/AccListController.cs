﻿using LLaQuery.Contracts.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagment.Presentaion.Api.Controllers
{
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