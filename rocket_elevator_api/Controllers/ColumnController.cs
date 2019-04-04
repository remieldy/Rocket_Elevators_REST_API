using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rocket_elevator_api.Models;

namespace rocket_elevator_api.Controllers
{

    [Route("api/column")]
    [ApiController]
    public class ColumnController: Controller
    {
        private readonly Rocket_elevatorContext _context;

        public ColumnController(Rocket_elevatorContext context)
        {
            _context = context;

            if (_context.columns.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.columns.Add(new Column { Id = 1 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Column>>> GetColumn()
        {
            return await _context.columns.ToListAsync();

        }

        // GET: api/id -----> ID/STATUS
        [HttpGet("{id}")]
        public async Task<ActionResult<Column>> GetColumnId(long id)
        {
            var column = await _context.columns.FindAsync(id);

            return column;
        }

        // GET - status and id only returned (all battery)
        [HttpGet("status")]
        public async Task<ActionResult<IEnumerable<ColumnStatus>>> GetColumnStatus()
        {
            return await _context.columnStatuses
                .FromSql("SELECT * FROM columns")
                .OrderBy(s => s.Id)
                .ToListAsync();

        }

        //PUT: api/elevetor/id - update status of battery
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColumnStatus(long id, Column column)
        {

            if (column.Id != id)
            {
                return BadRequest();
            }

            var current_column = _context.columns.Find(column.Id);
            current_column.Status = column.Status;

            if (column.Status == "Intervention" || column.Status == "Online" || column.Status == "Offline")
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