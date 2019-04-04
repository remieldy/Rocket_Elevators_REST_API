using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocket_elevator_api.Models;

namespace rocket_elevator_api.Controllers
{

    [Route("api/battery")]
    [ApiController]
    public class BatteryController: Controller
    {
        private readonly Rocket_elevatorContext _context;

        public BatteryController(Rocket_elevatorContext context)
        {
            _context = context;

            if (_context.batteries.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.batteries.Add(new Battery { Id = 1 });
                _context.SaveChanges();
            }
        }

        // GET - list all elevator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Battery>>> GetBattery()
        {
            return await _context.batteries.ToListAsync();

        }

        // GET: api/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Battery>> GetBatteryId(long id)
        {
            var battery = await _context.batteries.FindAsync(id);

            return battery;
        }

        // GET - status and id only returned (all battery)
        [HttpGet("status")]
        public async Task<ActionResult<IEnumerable<BatteryStatus>>> GetBatteryStatus()
        {
            return await _context.batteryStatuses
                .FromSql("SELECT * FROM batteries")
                .OrderBy(s => s.Id)
                .ToListAsync();

        }

        //PUT: api/elevetor/id - update status of battery
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatteryStatus(long id, Battery battery)
        {

            if (id != battery.Id)
            {
                return BadRequest();
            }

            var current_battery = _context.batteries.Find(battery.Id);
            current_battery.Status = battery.Status;

            if (battery.Status == "Intervention" || battery.Status == "Online" || battery.Status == "Offline")
            {
                await _context.SaveChangesAsync();
                return NoContent();

            }

            else
            {
                return BadRequest();
            }
        }

    }

}

