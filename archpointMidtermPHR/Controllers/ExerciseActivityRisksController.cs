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
    public class ExerciseActivityRisksController : Controller
    {
        private readonly ArchpointContext _context;

        public ExerciseActivityRisksController(ArchpointContext context)
        {
            _context = context;
        }

        // GET: ExerciseActivityRisks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExerciseActivityRisk.ToListAsync());
        }

        // GET: ExerciseActivityRisks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseActivityRisk = await _context.ExerciseActivityRisk
                .FirstOrDefaultAsync(m => m.ExerciseRiskId == id);
            if (exerciseActivityRisk == null)
            {
                return NotFound();
            }

            return View(exerciseActivityRisk);
        }

        // GET: ExerciseActivityRisks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExerciseActivityRisks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExerciseRiskId,AnyExercise,TypeOfExercise,FrequencyOfExercise,DurationOfExercise,IntensityLevel,DurationGoal,Comments")] ExerciseActivityRisk exerciseActivityRisk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exerciseActivityRisk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exerciseActivityRisk);
        }

        // GET: ExerciseActivityRisks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseActivityRisk = await _context.ExerciseActivityRisk.FindAsync(id);
            if (exerciseActivityRisk == null)
            {
                return NotFound();
            }
            return View(exerciseActivityRisk);
        }

        // POST: ExerciseActivityRisks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExerciseRiskId,AnyExercise,TypeOfExercise,FrequencyOfExercise,DurationOfExercise,IntensityLevel,DurationGoal,Comments")] ExerciseActivityRisk exerciseActivityRisk)
        {
            if (id != exerciseActivityRisk.ExerciseRiskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exerciseActivityRisk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseActivityRiskExists(exerciseActivityRisk.ExerciseRiskId))
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
            return View(exerciseActivityRisk);
        }

        // GET: ExerciseActivityRisks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseActivityRisk = await _context.ExerciseActivityRisk
                .FirstOrDefaultAsync(m => m.ExerciseRiskId == id);
            if (exerciseActivityRisk == null)
            {
                return NotFound();
            }

            return View(exerciseActivityRisk);
        }

        // POST: ExerciseActivityRisks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exerciseActivityRisk = await _context.ExerciseActivityRisk.FindAsync(id);
            _context.ExerciseActivityRisk.Remove(exerciseActivityRisk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseActivityRiskExists(int id)
        {
            return _context.ExerciseActivityRisk.Any(e => e.ExerciseRiskId == id);
        }
    }
}
