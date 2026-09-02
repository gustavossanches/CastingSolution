using CastingSolution.Models;
using CastingSolution.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CastingSolution.Controllers;

public class PromotoresController : Controller
{
    private readonly IPromotorService _promotorService;

    public PromotoresController(IPromotorService promotorService)
    {
        _promotorService = promotorService;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Promotor promotor)
    {
        if (ModelState.IsValid)
        {
            await _promotorService.CreateAsync(promotor);
            return RedirectToAction("Index", "Home");
        }
        return View(promotor);
    }
}
