using BankApp.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BankApp.Controllers
{
    public class BankController : Controller
    {
        private readonly BankContext _context;

        public BankController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.ApplicationUsers.ToList();
            return View(users);
        }
    }
}
