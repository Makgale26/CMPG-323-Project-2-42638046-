using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_API.Models;

namespace Project2_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobTelemetriesController : ControllerBase
    {
        private readonly sqlDatabaseCmpg323Context _context;

        public JobTelemetriesController(sqlDatabaseCmpg323Context context)
        {
            _context = context;
        }

        // GET: api/JobTelemetries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTelemetry>>> GetJobTelemetries()
        {
            return await _context.JobTelemetries.ToListAsync();
        }

        // GET: api/JobTelemetries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobTelemetry>> GetJobTelemetry(int id)
        {
            var jobTelemetry = await _context.JobTelemetries.FindAsync(id);

            if (jobTelemetry == null)
            {
                return NotFound();
            }

            return jobTelemetry;
        }

        // PUT: api/JobTelemetries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobTelemetry(int id, JobTelemetry jobTelemetry)
        {
            if (id != jobTelemetry.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobTelemetry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobTelemetryExists(id))
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

        // POST: api/JobTelemetries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobTelemetry>> PostJobTelemetry(JobTelemetry jobTelemetry)
        {
            _context.JobTelemetries.Add(jobTelemetry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobTelemetry", new { id = jobTelemetry.Id }, jobTelemetry);
        }

        // DELETE: api/JobTelemetries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobTelemetry(int id)
        {
            var jobTelemetry = await _context.JobTelemetries.FindAsync(id);
            if (jobTelemetry == null)
            {
                return NotFound();
            }

            _context.JobTelemetries.Remove(jobTelemetry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobTelemetryExists(int id)
        {
            return _context.JobTelemetries.Any(e => e.Id == id);
        }

       // GET: api/JobTelemetries/GetSavingsByProject
        [HttpGet("GetSavingsByProject")]
        public async Task<ActionResult> GetSavingsByProject(Guid projectId, DateTime startDate, DateTime endDate)
        {
            var telemetryItems = await _context.JobTelemetries
                .Where(jt => jt.ProjectId == projectId && jt.EntryDate >= startDate && jt.EntryDate <= endDate)
                .ToListAsync();

            var totalTimeSaved = telemetryItems.Sum(jt => jt.TimeSaved) ?? 0;
            var totalCostSaved = telemetryItems.Sum(jt => jt.CostSaved) ?? 0;

            return Ok(new
            {
                ProjectId = projectId,
                TotalTimeSaved = totalTimeSaved,
                TotalCostSaved = totalCostSaved
            });
        }

        // GET: api/JobTelemetries/GetSavingsByClient
        [HttpGet("GetSavingsByClient")]
        public async Task<ActionResult> GetSavingsByClient(Guid clientId, DateTime startDate, DateTime endDate)
        {
            var telemetryItems = await _context.JobTelemetries
                .Where(jt => jt.ClientId == clientId && jt.EntryDate >= startDate && jt.EntryDate <= endDate)
                .ToListAsync();

            var totalTimeSaved = telemetryItems.Sum(jt => jt.TimeSaved) ?? 0;
            var totalCostSaved = telemetryItems.Sum(jt => jt.CostSaved) ?? 0;

            return Ok(new
            {
                ClientId = clientId,
                TotalTimeSaved = totalTimeSaved,
                TotalCostSaved = totalCostSaved
            });
        }



    }

}


