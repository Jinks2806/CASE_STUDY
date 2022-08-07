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
    public class BondsController : ControllerBase
    {
        private readonly CaseStudy_Grp3Context _context;

        public BondsController(CaseStudy_Grp3Context context)
        {
            _context = context;
        }

        // GET: api/Bonds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bond>>> GetBonds()
        {
            if (_context.Bonds == null)
            {
                return NotFound();
            }
            return await _context.Bonds.ToListAsync();
        }

        // GET: api/Bonds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bond>> GetBond(int id)
        {
            if (_context.Bonds == null)
            {
                return NotFound();
            }
            var bond = await _context.Bonds.FindAsync(id);

            if (bond == null)
            {
                return NotFound();
            }

            return bond;
        }

        // PUT: api/Bonds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBond(int id, Bond bond)
        {
            Console.WriteLine("put");
            Console.WriteLine("id to be updated " + id);
            CaseStudy_Grp3Context ctx = new CaseStudy_Grp3Context();
            //ctx.ChangeTracker.Clear();
            Bond bondDetail = ctx.Bonds.Where(o => o.SecId == id).FirstOrDefault();

            // bondDetail.SecId = bond.SecId;
            //bondDetail.SecurityName = bond.SecurityName;

            bondDetail.SecurityDescription = bond.SecurityDescription;
            bondDetail.CouponRate = bond.CouponRate;
            bondDetail.IsCallable = bond.IsCallable;
            bondDetail.PenUltimateCouponDate = bond.PenUltimateCouponDate;
            bondDetail.AskPrice = bond.AskPrice;
            bondDetail.BidPrice = bond.BidPrice;
            bondDetail.PfcreditRating = bond.PfcreditRating;
            bondDetail.IsActive = bond.IsActive;
            ctx.SaveChanges();

            // await ctx.SaveChangesAsync();
            Console.WriteLine("after update: " + bondDetail.SecurityDescription);
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

        // POST: api/Bonds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bond>> PostBond(Bond bond)
        {
            if (_context.Bonds == null)
            {
                return Problem("Entity set 'CaseStudy_Grp3Context.Bonds'  is null.");
            }
            _context.Bonds.Add(bond);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BondExists(bond.SecId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBond", new { id = bond.SecId }, bond);
        }

        // DELETE: api/Bonds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBond(int id)
        {
            //if (_context.Bonds == null)
            //{
            //    return NotFound();
            //}
            //var bond = await _context.Bonds.FindAsync(id);
            //if (bond == null)
            //{
            //    return NotFound();
            //}

            //_context.Bonds.Remove(bond);
            //await _context.SaveChangesAsync();
            Console.WriteLine("delete");
            Console.WriteLine("id to be updated " + id);
            CaseStudy_Grp3Context ctx = new CaseStudy_Grp3Context();
            Bond bondDetail = ctx.Bonds.Where(o => o.SecId == id).FirstOrDefault();
            Console.WriteLine(bondDetail.IsActive.GetType());
            bondDetail.IsActive = 0;

            ctx.SaveChanges();
            Console.WriteLine("active value: " + bondDetail.IsActive);
            Console.WriteLine("deleted");

            return NoContent();
        }

        private bool BondExists(int id)
        {
            return (_context.Bonds?.Any(e => e.SecId == id)).GetValueOrDefault();
        }
    }
}