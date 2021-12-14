using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netflix_Api.Models;

namespace Netflix_Api.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller {
        private NetflixDBContext context;

        public AccountController(NetflixDBContext context) {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddAccount(AccountModel account) {
            if (AccountExists(account.Email)) {
                return NotFound();
            }

            await context.Accounts!.AddAsync(account);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAccount), new {id = account.AccountId}, account);
        }

        private bool AccountExists(string email) {
            return context.Accounts!.Any(x => x.Email.Equals(email));
        }
        
        [HttpGet("{id}")]
        public ActionResult<AccountModel> GetAccountById([FromQuery] int id) {
            if (context.Accounts!.Count() == 0) {
                return NotFound();
            }

            AccountModel? account = context.Accounts!.Where(x => x.AccountId == id).FirstOrDefault();
            if (account == null) {
                return NotFound();
            }

            return account;
        }

        [HttpGet]
        public ActionResult<AccountModel> GetAccount(string email, string password) {
            if (context.Accounts!.Count() == 0) {
                return NotFound();
            }
            
            AccountModel? account = context.Accounts!.Where(x => email.Equals(x.Email) && password.Equals(x.Password)).Include(x => x.Plan).Include(x => x.Payment).FirstOrDefault();
            if (account == null) {
                return NotFound();
            }

            return account;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AccountModel>> UpdateAccount(int id, [FromBody] AccountModel account) {
            if (id != account.AccountId) {
                return BadRequest();
            }

            context.Entry(account).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}