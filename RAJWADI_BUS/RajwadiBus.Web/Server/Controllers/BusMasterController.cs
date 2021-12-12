using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RajwadiBus.Web.Server.Data;
using RajwadiBus.Web.Shared;
using System.Linq;
using System.Threading.Tasks;

namespace RajwadiBus.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusMasterController : ControllerBase
    {
        private readonly RajwadiBusDBContext _context;
        public BusMasterController(RajwadiBusDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lstBusMaster = await _context.BusMasters.ToListAsync();
            return Ok(lstBusMaster);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var objBusMaster = await _context.BusMasters.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(objBusMaster);
        }

        [HttpPost]
        public async Task<IActionResult> Post(BusMaster objBusMaster)
        {
            _context.Add(objBusMaster);
            await _context.SaveChangesAsync();
            return Ok(objBusMaster.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(BusMaster objBusMaster)
        {
            _context.Entry(objBusMaster).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var objBusMaster = _context.BusMasters.Where(x=>x.Id == id).FirstOrDefault();
            _context.Remove(objBusMaster);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}