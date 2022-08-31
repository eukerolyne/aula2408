using aula2408.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aula2408.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            if (id == 1)
                Response.Redirect("../Privacy");
            if (id == 2)
                Response.Redirect("../Privacy");  
            
            if (id == 3)
                Response.Redirect("../Caixas");   
            if (id == 4)
                Response.Redirect("../Caixas");   
            if (id == 5)
                Response.Redirect("../Caixas");  

            if (id == 6)
                Response.Redirect("../Imagem");   
            if (id == 7)
                Response.Redirect("../Imagem");

            return View();
        }

        public IActionResult Privacy( int? id)
        {
            if (id == 1)
                ViewData["cor"] = "blue";
            if (id == 2)
                ViewData["cor"] = "green";

            return View();
        }
        public IActionResult Caixas(int? id)
        {
            if (id == 3)
                ViewData["quantidade"] = 3;
            if (id == 4)
                ViewData["quantidade"] = 6;
            if (id == 5)
                ViewData["quantidade"] = 9;
            return View();
        }       
        public IActionResult Imagem(int? id)
        {
            if (id == 6)
                ViewData["imagem"] = 1;
            if (id == 7)
                ViewData["imagem"] = 2;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}