using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDManager.Controllers
{
    public class SessionLogController : Controller
    {
        private readonly AppDbContext _context;

        public SessionLogController(AppDbContext context)
        {
            _context = context;
        }

        // Actions go here
    }
}