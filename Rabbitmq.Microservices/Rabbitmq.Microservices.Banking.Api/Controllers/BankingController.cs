using Microsoft.AspNetCore.Mvc;
using Rabbitmq.Microservices.Banking.Application.Interfaces;
using Rabbitmq.Microservices.Banking.Domain.Models;

namespace Rabbitmq.Microservices.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var task = _accountService.GetAccountsAsync();
            return Ok(await task);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountTransfer accountTransfer)
        {
            await _accountService.TransferAsync(accountTransfer);
            return Ok();
        }
    }
}
