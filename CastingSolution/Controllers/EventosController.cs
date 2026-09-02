using CastingSolution.Models;
using CastingSolution.Services;
using Microsoft.AspNetCore.Mvc;
using CastingSolution.Interfaces;

namespace CastingSolution.Controllers;

public class EventosController : Controller
{
    private readonly IEventoService _eventoService;

    public EventosController(IEventoService eventoService)
    {
        _eventoService = eventoService;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Evento evento)
    {
        if (ModelState.IsValid)
        {
            await _eventoService.CreateAsync(evento);
            return RedirectToAction("Index", "Home");
        }
        return View(evento);
    }
}
