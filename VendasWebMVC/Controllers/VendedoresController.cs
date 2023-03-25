using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Services;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.findAll();
            return View(list);
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor obj)
        {
            _vendedorService.Insert(obj);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Vendedor obj)
        {
            _vendedorService.Delete(obj);
            return RedirectToAction(nameof(Index));
        }
    }
}
