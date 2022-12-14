using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTAPI.Models;

namespace RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquitiesController : ControllerBase
    {
        private CaseStudy_Grp3Context _context;

        public EquitiesController(CaseStudy_Grp3Context context)
        {
            _context = context;
        }

        // GET: api/Equities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equity>>> GetEquities()
        {
            if (_context.Equities == null)
            {
                return NotFound();
            }
            return await _context.Equities.ToListAsync();
        }

        // GET: api/Equities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equity>> GetEquity(int id)
        {
            if (_context.Equities == null)
            {
                return NotFound();
            }
            var equity = await _context.Equities.FindAsync(id);

            if (equity == null)
            {
                return NotFound();
            }

            return equity;
        }

        // PUT: api/Equities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquity(int id, Equity equity)
        {
            //if (id != equity.SecId)
            //{
            //    return BadRequest();
            //}
            Console.WriteLine("put");
            Console.WriteLine("id to be updated " + id);
            CaseStudy_Grp3Context ctx = new CaseStudy_Grp3Context();
            //ctx.ChangeTracker.Clear();
            Equity equityDetail = ctx.Equities.Where(o => o.SecId == id).FirstOrDefault();

            // equityDetail.SecId = equity.SecId;
            //equityDetail.SecurityName = equity.SecurityName;

            equityDetail.SecurityDescription = equity.SecurityDescription;
            equityDetail.PriceCurrency = equity.PriceCurrency;
            equityDetail.SharesOutstanding = equity.SharesOutstanding;
            equityDetail.OpenPrice = equity.OpenPrice;
            equityDetail.ClosePrice = equity.ClosePrice;
            equityDetail.DeclaredDate = equity.DeclaredDate;
            equityDetail.PfcreditRating = equity.PfcreditRating;

            ctx.SaveChanges();

            // await ctx.SaveChangesAsync();
            Console.WriteLine("after update: " + equityDetail.SecurityDescription);
            Console.WriteLine("done");


            //try
            //{

            //    //ctx.Dispose();
            //    //ctx.Entry(equity).State = EntityState.Detached;
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!EquityExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return NoContent();
        }

        // POST: api/Equities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Equity>> PostEquity(Equity equity)
        {
            if (_context.Equities == null)
            {
                return Problem("Entity set 'CaseStudy_Grp3Context.Equities'  is null.");
            }
            _context.Equities.Add(equity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EquityExists(equity.SecId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEquity", new { id = equity.SecId }, equity);
        }

        // DELETE: api/Equities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquity(int id)
        {
            //if (_context.Equities == null)
            //{
            //    return NotFound();
            //}
            //var equity = await _context.Equities.FindAsync(id);
            //if (equity == null)
            //{
            //    return NotFound();
            //}

            //_context.Equities.Remove(equity);
            //await _context.SaveChangesAsync();
            Console.WriteLine("delete");
            Console.WriteLine("id to be updated " + id);
            CaseStudy_Grp3Context ctx = new CaseStudy_Grp3Context();
            Equity equityDetail = ctx.Equities.Where(o => o.SecId == id).FirstOrDefault();
            equityDetail.IsActive = false;

            ctx.SaveChanges();
            Console.WriteLine("active value: " + equityDetail.IsActive);
            Console.WriteLine("deleted");

            return NoContent();
        }

        private bool EquityExists(int id)
        {
            return (_context.Equities?.Any(e => e.SecId == id)).GetValueOrDefault();
        }
    }
}