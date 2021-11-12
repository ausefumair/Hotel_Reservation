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
    public class CompanyPlansController : ControllerBase
    {
        private readonly CompanyPlanDbContext _context;

        public CompanyPlansController(CompanyPlanDbContext context)
        {
            _context = context;
        }

        // GET: api/CompanyPlans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyPlan>>> GetCompanyPlans()
        {
            return await _context.CompanyPlans.ToListAsync();
        }

        // GET: api/CompanyPlans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyPlan>> GetCompanyPlan(int id)
        {
            var companyPlan = await _context.CompanyPlans.FindAsync(id);

            if (companyPlan == null)
            {
                return NotFound();
            }

            return companyPlan;
        }

        // PUT: api/CompanyPlans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompanyPlan(int id, CompanyPlan companyPlan)
        {
            if (id != companyPlan.plan_id)
            {
                return BadRequest();
            }

            _context.Entry(companyPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyPlanExists(id))
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

        // POST: api/CompanyPlans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CompanyPlan>> PostCompanyPlan(CompanyPlan companyPlan)
        {
            _context.CompanyPlans.Add(companyPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompanyPlan", new { id = companyPlan.plan_id }, companyPlan);
        }

        // DELETE: api/CompanyPlans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyPlan(int id)
        {
            var companyPlan = await _context.CompanyPlans.FindAsync(id);
            if (companyPlan == null)
            {
                return NotFound();
            }

            _context.CompanyPlans.Remove(companyPlan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyPlanExists(int id)
        {
            return _context.CompanyPlans.Any(e => e.plan_id == id);
        }
    }
}
