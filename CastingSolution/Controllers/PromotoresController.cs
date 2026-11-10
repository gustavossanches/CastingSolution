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
    private readonly IFotoPromotorService _fotoPromotorService;

    public PromotoresController(IPromotorService promotorService, IFotoPromotorService fotoPromotorService)
    {
        _promotorService = promotorService;
        _fotoPromotorService = fotoPromotorService;
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

            if (!resultado.IsSuccess)
            {
                ModelState.AddModelError(string.Empty, resultado.Error.Message);
                return View(viewModel);
            }
            TempData["sucesso"] = "Promotor criado com sucesso!";
            return RedirectToAction("ListarPromotores");
        }
        return View(viewModel);
    }

    public async Task<IActionResult> PromotorDetalhe(int id)
    {
        var promotor = await _promotorService.PromotorDetalhe(id); 
        return View(promotor);
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

    public async Task<IActionResult> Foto(int id)
    { 
        var foto = await _fotoPromotorService.BuscarFoto(id);
        return File(foto.Conteudo, "image/jpeg");
    }

}
