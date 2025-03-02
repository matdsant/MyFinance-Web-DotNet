using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myfinance_web_dotnet.Models;
using myfinance_web_dotnet_service.Interfaces;

namespace myfinance_web_dotnet.Controllers
{
    [Route("[controller]")]
    public class PlanoContaController : Controller
    {
        private readonly ILogger<PlanoContaController> _logger;
        private readonly IPlanoContaService _planoContaService;

        public PlanoContaController(
            ILogger<PlanoContaController> logger,
            IPlanoContaService planoContaService
            )
        {
            _logger = logger;
            _planoContaService = planoContaService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var listaPlanoContas =_planoContaService.ListarRegistros();
            List<PlanoContaModel> listaPlanoContaModel = new List<PlanoContaModel>();

            foreach (var item in listaPlanoContas){
                var itemPlanoConta = new PlanoContaModel(){
                    Id = item.Id,
                    Descricao = item.Descricao,
                    Tipo = item.Tipo
                };

                listaPlanoContaModel.Add(itemPlanoConta);
            }
            ViewBag.listaPlanoConta = listaPlanoContaModel;
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}