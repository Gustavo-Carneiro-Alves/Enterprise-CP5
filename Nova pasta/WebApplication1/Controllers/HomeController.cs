using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApplication1.Models;

namespace TesteCP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            return View();
        }

        public IActionResult CadastrarClientesTeste(ClienteTeste clienteTeste)
        {
            return View(clienteTeste);
        }

        [HttpGet]
        public IActionResult CadastrarProdutos()
        {
            //ViewBag.categorias = new SelectList(categorias, "CategoriaId", "Name");
            return View();
        }

        public IActionResult Resposta(ClienteTeste clienteTeste)
        {
            return View(clienteTeste);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}