using DnDManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDManager.Controllers
{
    public class CampaignController : Controller
    {
        // private readonly AppDbContext _context;

        //public CampaignController(AppDbContext context)
        //{
        //    _context = context;
        //}

        // Actions go here
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
