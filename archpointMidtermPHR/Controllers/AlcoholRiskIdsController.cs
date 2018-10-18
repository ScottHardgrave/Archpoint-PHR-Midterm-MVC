using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using archpointMidtermPHR.Models;

namespace archpointMidtermPHR.Controllers
{
    public class AlcoholRiskIdsController : Controller
    {
        private readonly ArchpointContext _context;

        public AlcoholRiskIdsController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: AlcoholRiskIds
        public async Task<IActionResult> Index()
        {
            return View(await _context.AlcoholRiskId.ToListAsync());
        }

        // GET: AlcoholRiskIds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRiskId = await _context.AlcoholRiskId
                .FirstOrDefaultAsync(m => m.AlcoholUseRiskId == id);
            if (alcoholRiskId == null)
            {
                return NotFound();
            }

            return View(alcoholRiskId);
        }

        // GET: AlcoholRiskIds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AlcoholRiskIds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlcoholUseRiskId,DrinkAlc,DailyDrinkCount,WeekendDrinkCount,SocialDrinkCount,YearsQuitDrinking,TreatedForAlcAbuse,YearTreated,LengthOfTreatment,TypeOfTreatment,Comments")] AlcoholRiskId alcoholRiskId)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alcoholRiskId);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alcoholRiskId);
        }

        // GET: AlcoholRiskIds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRiskId = await _context.AlcoholRiskId.FindAsync(id);
            if (alcoholRiskId == null)
            {
                return NotFound();
            }
            return View(alcoholRiskId);
        }

        // POST: AlcoholRiskIds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlcoholUseRiskId,DrinkAlc,DailyDrinkCount,WeekendDrinkCount,SocialDrinkCount,YearsQuitDrinking,TreatedForAlcAbuse,YearTreated,LengthOfTreatment,TypeOfTreatment,Comments")] AlcoholRiskId alcoholRiskId)
        {
            if (id != alcoholRiskId.AlcoholUseRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alcoholRiskId);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlcoholRiskIdExists(alcoholRiskId.AlcoholUseRiskId))
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
            return View(alcoholRiskId);
        }

        // GET: AlcoholRiskIds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alcoholRiskId = await _context.AlcoholRiskId
                .FirstOrDefaultAsync(m => m.AlcoholUseRiskId == id);
            if (alcoholRiskId == null)
            {
                return NotFound();
            }

            return View(alcoholRiskId);
        }

        // POST: AlcoholRiskIds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alcoholRiskId = await _context.AlcoholRiskId.FindAsync(id);
            _context.AlcoholRiskId.Remove(alcoholRiskId);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlcoholRiskIdExists(int id)
        {
            return _context.AlcoholRiskId.Any(e => e.AlcoholUseRiskId == id);
        }
    }
}
