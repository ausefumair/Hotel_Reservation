using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation.Models;

namespace Hotel_Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationStatusController : ControllerBase
    {
        private readonly ReservationStatusDbContext _context;

        public ReservationStatusController(ReservationStatusDbContext context)
        {
            _context = context;
        }

        // GET: api/ReservationStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationStatus>>> GetReservationStatus()
        {
            return await _context.ReservationStatus.ToListAsync();
        }

        // GET: api/ReservationStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationStatus>> GetReservationStatus(int id)
        {
            var reservationStatus = await _context.ReservationStatus.FindAsync(id);

            if (reservationStatus == null)
            {
                return NotFound();
            }

            return reservationStatus;
        }

        // PUT: api/ReservationStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationStatus(int id, ReservationStatus reservationStatus)
        {
            if (id != reservationStatus.status_id)
            {
                return BadRequest();
            }

            _context.Entry(reservationStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationStatusExists(id))
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

        // POST: api/ReservationStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReservationStatus>> PostReservationStatus(ReservationStatus reservationStatus)
        {
            _context.ReservationStatus.Add(reservationStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservationStatus", new { id = reservationStatus.status_id }, reservationStatus);
        }

        // DELETE: api/ReservationStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservationStatus(int id)
        {
            var reservationStatus = await _context.ReservationStatus.FindAsync(id);
            if (reservationStatus == null)
            {
                return NotFound();
            }

            _context.ReservationStatus.Remove(reservationStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservationStatusExists(int id)
        {
            return _context.ReservationStatus.Any(e => e.status_id == id);
        }
    }
}
