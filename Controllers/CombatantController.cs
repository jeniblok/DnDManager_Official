using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDManager.Controllers
{
    public class CombatantController : Controller
    {
        private readonly AppDbContext _context;

        public CombatantController(AppDbContext context)
        {
            _context = context;
        }

        // Actions go here
    }
}