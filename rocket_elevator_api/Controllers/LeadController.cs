using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocket_elevator_api.Models;

namespace rocket_elevator_api.Controllers
{

    [Route("api/lead")]
    [ApiController]
    public class LeadController : Controller
    {
    
            public Rocket_elevatorContext _context;

            public LeadController(Rocket_elevatorContext context)
            {
                _context = context;

                if (_context.leads.Count() == 0)
                {
                    _context.leads.Add(new Lead { Id = 1 });
                    _context.SaveChanges();
                }
            }
            // GET leads last 30 days -> not customer
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Lead>>> GetLead()
            {
                return await _context.leads
                    .FromSql("SELECT * FROM leads " +
                    	"WHERE created_at BETWEEN NOW() - INTERVAL 30 DAY AND NOW() AND customer_id IS NULL")
                    .OrderBy(s => s.Id)
                    .ToListAsync();
          
            }
        
    }
}
