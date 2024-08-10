using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_API.Models;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class TelemetryController : ControllerBase
{
    private readonly sqlDatabaseCmpg323Context _context;

    public TelemetryController(sqlDatabaseCmpg323Context context)
    {
        _context = context;
    }

    // GET: api/telemetry
    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobTelemetry>>> GetJobTelemetries()
    {
        return await _context.JobTelemetries.ToListAsync();
    }

    // GET: api/telemetry/5
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

    // POST: api/telemetry
    [HttpPost]
    public async Task<ActionResult<JobTelemetry>> PostJobTelemetry(JobTelemetry jobTelemetry)
    {
        _context.JobTelemetries.Add(jobTelemetry);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetJobTelemetry), new { id = jobTelemetry.Id }, jobTelemetry);
    }

    // PATCH: api/telemetry/5
    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchJobTelemetry(int id, JobTelemetry jobTelemetry)
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

    // DELETE: api/telemetry/5
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
}
