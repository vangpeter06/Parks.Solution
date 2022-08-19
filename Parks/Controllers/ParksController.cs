using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parks.Models;

namespace Parks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private readonly ParksContext _db;

        public ParksController(ParksContext db)
        {
            _db = db;
        }

        //GET api/parks
        [HttpGet]
        public async Task<List<Park>>
        Get(string name, string location, string type)
        {
            IQueryable<Park> query = _db.Parks.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if (location != null)
            {
                query = query.Where(entry => entry.Location == location);
            }

            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }

            return await query.ToListAsync();
        }

        //POST api/parks
        [HttpPost]
        public async Task<ActionResult<Park>> Post(Park park)
        {
            _db.Parks.Add (park);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPark),
            new { id = park.ParkId },
            park);
        }

        // GET: api/Parks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetPark(int id)
        {
            var park = await _db.Parks.FindAsync(id);

            if (park == null)
            {
                return NotFound();
            }

            return park;
        }

        // PUT: api/Parks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Park park)
        {
            if (id != park.ParkId)
            {
                return BadRequest();
            }

            _db.Entry(park).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ParkExists(int id)
        {
            return _db.Parks.Any(e => e.ParkId == id);
        }

        // DELETE: api/Parks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
            var park = await _db.Parks.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }

            _db.Parks.Remove (park);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
