using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Core.Models;

namespace Mobiles.Web.Controllers
{
    public class SmartphoneController : Controller
    {
        private readonly PhonesDbContext _context;

        // Dependency injection via (Program.cs :: builder.Services.AddDbContext<PhonesDbContext>)
        public SmartphoneController(PhonesDbContext context)
        {
            _context = context;
        }

        // GET: Smartphone
        public async Task<IActionResult> Index()
        {
            var phonesDbContext = _context.Smartphones.Include(s => s.Cpu);
            return View(await phonesDbContext.ToListAsync());
        }

        // GET: Smartphone/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Smartphones == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphones
                .Include(s => s.Cpu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphone == null)
            {
                return NotFound();
            }

            return View(smartphone);
        }

        // GET: Smartphone/Create
        public IActionResult Create()
        {
            // Additional data to be used in corresponding view file.
            ViewData["CpuId"] = new SelectList(_context.SmartphoneCpus, "Id", null);
            return View();
        }

        // POST: Smartphone/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BatteryPower_mAh,IsDualSim,InternalMemory_GB,Ram_MB,PriceRange,CpuId")] Smartphone smartphone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smartphone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Additional data to be used in corresponding view file.
            ViewData["CpuId"] = new SelectList(_context.SmartphoneCpus, "Id", null, smartphone.CpuId);
            return View(smartphone);
        }

        // GET: Smartphone/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Smartphones == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphones.FindAsync(id);
            if (smartphone == null)
            {
                return NotFound();
            }
            // Additional data to be used in corresponding view file.
            ViewData["CpuId"] = new SelectList(_context.SmartphoneCpus, "Id", null, smartphone.CpuId);
            return View(smartphone);
        }

        // POST: Smartphone/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BatteryPower_mAh,IsDualSim,InternalMemory_GB,Ram_MB,PriceRange,CpuId")] Smartphone smartphone)
        {
            if (id != smartphone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smartphone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmartphoneExists(smartphone.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            // Additional data to be used in corresponding view file.
            ViewData["CpuId"] = new SelectList(_context.SmartphoneCpus, "Id", null, smartphone.CpuId);
            return View(smartphone);
        }

        // GET: Smartphone/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Smartphones == null)
            {
                return NotFound();
            }

            var smartphone = await _context.Smartphones
                .Include(s => s.Cpu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphone == null)
            {
                return NotFound();
            }

            return View(smartphone);
        }

        // POST: Smartphone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Smartphones == null)
            {
                return Problem("Entity set 'PhonesDbContext.Smartphones'  is null.");
            }
            var smartphone = await _context.Smartphones.FindAsync(id);
            if (smartphone != null)
            {
                _context.Smartphones.Remove(smartphone);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmartphoneExists(int id)
        {
            return (_context.Smartphones?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
