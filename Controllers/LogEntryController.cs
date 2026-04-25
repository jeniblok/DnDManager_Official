using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDManager.Controllers
{
    public class LogEntryController : Controller
    {
        private readonly AppDbContext _context;

        public LogEntryController(AppDbContext context)
        {
            _context = context;
        }

        // Actions go here
    }
}