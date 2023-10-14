using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Models;

namespace Mobiles.Web.Controllers
{
    public class SmartphoneCpuController : Controller
    {
        private readonly PhonesDbContext _context;

        public SmartphoneCpuController(PhonesDbContext context)
        {
            _context = context;
        }

        // GET: SmartphoneCpu
        public async Task<IActionResult> Index()
        {
            return _context.SmartphoneCpus != null ?
                        View(await _context.SmartphoneCpus.ToListAsync()) :
                        Problem("Entity set 'PhonesDbContext.SmartphoneCpus'  is null.");
        }

        // GET: SmartphoneCpu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SmartphoneCpus == null)
            {
                return NotFound();
            }

            var smartphoneCpu = await _context.SmartphoneCpus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphoneCpu == null)
            {
                return NotFound();
            }

            return View(smartphoneCpu);
        }

        // GET: SmartphoneCpu/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SmartphoneCpu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CoreCount,ClockSpeedMHz,GpuName")] SmartphoneCpu smartphoneCpu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smartphoneCpu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smartphoneCpu);
        }

        // GET: SmartphoneCpu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SmartphoneCpus == null)
            {
                return NotFound();
            }

            var smartphoneCpu = await _context.SmartphoneCpus.FindAsync(id);
            if (smartphoneCpu == null)
            {
                return NotFound();
            }
            return View(smartphoneCpu);
        }

        // POST: SmartphoneCpu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CoreCount,ClockSpeedMHz,GpuName")] SmartphoneCpu smartphoneCpu)
        {
            if (id != smartphoneCpu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smartphoneCpu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmartphoneCpuExists(smartphoneCpu.Id))
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
            return View(smartphoneCpu);
        }

        // GET: SmartphoneCpu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SmartphoneCpus == null)
            {
                return NotFound();
            }

            var smartphoneCpu = await _context.SmartphoneCpus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (smartphoneCpu == null)
            {
                return NotFound();
            }

            return View(smartphoneCpu);
        }

        // POST: SmartphoneCpu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SmartphoneCpus == null)
            {
                return Problem("Entity set 'PhonesDbContext.SmartphoneCpus'  is null.");
            }
            var smartphoneCpu = await _context.SmartphoneCpus.FindAsync(id);
            if (smartphoneCpu != null)
            {
                _context.SmartphoneCpus.Remove(smartphoneCpu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmartphoneCpuExists(int id)
        {
            return (_context.SmartphoneCpus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
