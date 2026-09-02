using CastingSolution.Data;
using CastingSolution.Models;
using CastingSolution.Models.DTOs;
using CastingSolution.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CastingSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eventosAtivos = await _context.Eventos
                .Where(e => e.Status == StatusEvento.Ativo)
                .OrderBy(e => e.DataInicio)
                .ToListAsync();

            var viewModel = new HomeViewModel
            {
                EventosAtivos = eventosAtivos
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
