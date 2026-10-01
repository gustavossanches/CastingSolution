using CastingSolution.Models;
using CastingSolution.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CastingSolution.Models.ViewModel.PromotorResumoViewModel;
using CastingSolution.Models.ViewModel.PromotorViewModel;
using CastingSolution.Map;

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
    public async Task<IActionResult> Create(CriarPromotorViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var resultado = await _promotorService.CreateAsync(viewModel);

            if(!resultado.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, resultado.Error.Message);
                return View(viewModel);
            }
            TempData["sucesso"] = "Promotor criado com sucesso!";
            return RedirectToAction("ListarPromotores");
        }
        return View(viewModel);
    }

    public async Task<IActionResult> ListarPromotores()
    {
        var PromotoresDTO = await _promotorService.ListarPromotorResumo();

        var viewModel = new ListarPromotoresViewModel
        {
            Promotores = PromotoresDTO
        };
        return View(viewModel);
    }

}
