
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocket_elevator_api.Models;
using MySql.Data.MySqlClient;

namespace rocket_elevator_api.Controllers
{
    [Route("api/elevator")]
    [ApiController]
    public class ElevatorController : Controller
    {
        public Rocket_elevatorContext _context;

        public ElevatorController(Rocket_elevatorContext context)
        {
            _context = context;

            if (_context.elevators.Count() == 0)
            {
                _context.elevators.Add(new Elevator { Id = 1 });
                _context.SaveChanges();
            }
        }

        // GET: api/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetElevator()
        {
            return await _context.elevators.ToListAsync();

        }
        // GET - status and id only returned (all elevator)
        [HttpGet("status")]
        public async Task<ActionResult<IEnumerable<ElevatorStatus>>> GetElevatorStatus()
        {
            return await _context.elevatorStatuses
                .FromSql("SELECT * FROM elevators")
                .OrderBy(s => s.Id)
                .ToListAsync();

        }

        // GET: api/id - get on specific elevator
        [HttpGet("{id}")]
        public async Task<ActionResult<Elevator>> GetElevatorId(long id)
        {
            var elevator = await _context.elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }

            return elevator;
        }

        // GET - get all elevator offline
        [HttpGet("offline")]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetElevatorOffline()
        {
            return await _context.elevators
                .FromSql("SELECT * FROM elevators where status = 'Offline'")
                .OrderBy(s => s.Id)
                .ToListAsync();
        }


        //PUT: api/elevetor/id - update status of elevator
       [HttpPut("{id}")]
        public async Task<IActionResult> PutElevatorStatus(long id, Elevator elevator)
        {

            if (id != elevator.Id)
            {
                return BadRequest();
            }

            var current_elevator = _context.elevators.Find(elevator.Id);
            current_elevator.Status = elevator.Status;

            if (elevator.Status == "Intervention" || elevator.Status == "Online" || elevator.Status == "Offline"){

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
