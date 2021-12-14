using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netflix_Api.Models;

namespace Netflix_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller 
    {
        private NetflixDBContext context;

        public PaymentController(NetflixDBContext context) 
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<PaymentModel>> Insert(PaymentModel payment) {
            await context.Payments!.AddAsync(payment);
            await context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetPayment), new { id = payment.PaymentId }, payment);
        }

        [HttpGet]
        public ActionResult<PaymentModel> GetPayment(int id) 
        {
            if (context.Payments!.Count() == 0) {
                return NotFound();
            }

            PaymentModel? payment = context.Payments!.Where(x => x.PaymentId == id).FirstOrDefault();
            if (payment == null) {
                return NotFound();
            }

            return payment;
        }
    }
}