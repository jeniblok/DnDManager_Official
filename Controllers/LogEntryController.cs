using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DnDManager.Controllers
{
    public class LogEntryController : Controller
    {
        private readonly AppDbContext _context;

        public LogEntryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var logEntries = _context.LogEntries
                .Include(l => l.Encounter)
                .ToList();

            return View(logEntries);
        }

        public IActionResult Details(int id)
        {
            var logEntry = _context.LogEntries
                .Include(l => l.Encounter)
                .FirstOrDefault(l => l.Id == id);

            if (logEntry == null)
            {
                return NotFound();
            }

            return View(logEntry);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LogEntry logEntry)
        {
            if (ModelState.IsValid)
            {
                _context.LogEntries.Add(logEntry);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(logEntry);
        }

        public IActionResult Edit(int id)
        {
            var logEntry = _context.LogEntries.Find(id);

            if (logEntry == null)
            {
                return NotFound();
            }

            return View(logEntry);
        }

        [HttpPost]
        public IActionResult Edit(LogEntry logEntry)
        {
            if (ModelState.IsValid)
            {
                _context.LogEntries.Update(logEntry);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(logEntry);
        }

        public IActionResult Delete(int id)
        {
            var logEntry = _context.LogEntries.Find(id);

            if (logEntry == null)
            {
                return NotFound();
            }

            return View(logEntry);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var logEntry = _context.LogEntries.Find(id);

            if (logEntry != null)
            {
                _context.LogEntries.Remove(logEntry);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
