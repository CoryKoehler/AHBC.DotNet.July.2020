using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novemember5thWebApi.Data;

namespace Novemember5thWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairRequestsController : ControllerBase
    {
        private readonly CarShopContext _context;

        public RepairRequestsController(CarShopContext context)
        {
            _context = context;
        }

        // GET: api/RepairRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RepairRequest>>> GetRepairRequest()
        {
            return await _context.RepairRequest.ToListAsync();
        }

        // GET: api/RepairRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RepairRequest>> GetRepairRequest(int id)
        {
            //Jason is right this would be slow if we had a lot of parts
            //a better way to do this is to match on repair request then hydrate the part afterwards
            var repairRequests = await _context.RepairRequest.Include(_ => _.Part).ToListAsync();
            var repairRequest = repairRequests.SingleOrDefault(_ => _.Id == id);

            if (repairRequest == null)
            {
                return NotFound();
            }

            return repairRequest;
        }

        // PUT: api/RepairRequests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRepairRequest(int id, RepairRequest repairRequest)
        {
            if (id != repairRequest.Id)
            {
                return BadRequest();
            }

            _context.Entry(repairRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RepairRequestExists(id))
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

        // POST: api/RepairRequests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RepairRequest>> PostRepairRequest(RepairRequest repairRequest)
        {
            _context.RepairRequest.Add(repairRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRepairRequest", new { id = repairRequest.Id }, repairRequest);
        }

        // DELETE: api/RepairRequests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RepairRequest>> DeleteRepairRequest(int id)
        {
            var repairRequest = await _context.RepairRequest.FindAsync(id);
            if (repairRequest == null)
            {
                return NotFound();
            }

            _context.RepairRequest.Remove(repairRequest);
            await _context.SaveChangesAsync();

            return repairRequest;
        }

        private bool RepairRequestExists(int id)
        {
            return _context.RepairRequest.Any(e => e.Id == id);
        }
    }
}
