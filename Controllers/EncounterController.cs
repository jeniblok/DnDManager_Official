using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DnDManager.Controllers
{
    public class EncounterController : Controller
    {
        private readonly AppDbContext _context;

        public EncounterController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var encounters = _context.Encounters
                .Include(e => e.SessionLog)
                .ToList();

            return View(encounters);
        }

        public IActionResult Details(int id)
        {
            var encounter = _context.Encounters
                .Include(e => e.SessionLog)
                .Include(e => e.LogEntries)
                .FirstOrDefault(e => e.Id == id);

            if (encounter == null)
            {
                return NotFound();
            }

            return View(encounter);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                _context.Encounters.Add(encounter);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(encounter);
        }

        public IActionResult Edit(int id)
        {
            var encounter = _context.Encounters.Find(id);

            if (encounter == null)
            {
                return NotFound();
            }

            return View(encounter);
        }

        [HttpPost]
        public IActionResult Edit(Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                _context.Encounters.Update(encounter);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(encounter);
        }

        public IActionResult Delete(int id)
        {
            var encounter = _context.Encounters.Find(id);

            if (encounter == null)
            {
                return NotFound();
            }

            return View(encounter);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var encounter = _context.Encounters.Find(id);

            if (encounter != null)
            {
                _context.Encounters.Remove(encounter);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
