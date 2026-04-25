using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDManager.Controllers
{
    public class EncounterController : Controller
    {
        private readonly AppDbContext _context;

        public EncounterController(AppDbContext context)
        {
            _context = context;
        }

        // Actions go here
    }
}