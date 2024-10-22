using Apoio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Apoio.Controllers
{
    public class ApoioController : Controller
    {
        public IActionResult Empresa()
        {
            ViewData["Title"] = "Controle de Empresas";
            return View();
        }
    }
}
