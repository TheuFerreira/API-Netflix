using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Netflix_Api.Models;

namespace Netflix_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanController : Controller
    {
        private NetflixDBContext context;

        public PlanController(NetflixDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlanModel>>> GetPlans()
        {
            return await context.Plans!.ToListAsync();
        } 
    }
}
