using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocket_elevator_api.Models;

namespace rocket_elevator_api.Controllers
{

    [Route("api/building")]
    [ApiController]
    public class BuildingController: Controller
    {
        public Rocket_elevatorContext _context;

        public BuildingController(Rocket_elevatorContext context)
        {
            _context = context;

            if (_context.buildings.Count() == 0)
            {

                _context.buildings.Add(new Building { Id = 1 });
                _context.SaveChanges();
            }
        }

        // GET - status and id only returned (all elevator)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Building>>> GetElevatorStatus()
        {
            return await _context.buildings
                .FromSql("SELECT DISTINCT b.* FROM buildings AS b JOIN batteries bat ON b.id = bat.building_id " +
                	"JOIN columns c ON bat.id = c.battery_id " +
                	"JOIN elevators e ON c.id = e.column_id " +
                	"WHERE bat.status = 'Intervention' OR c.status = 'Intervention' OR e.status = 'Intervention' " +
                	"ORDER BY b.id")
                .OrderBy(s => s.Id)
                .ToListAsync();

        }
    }
}
