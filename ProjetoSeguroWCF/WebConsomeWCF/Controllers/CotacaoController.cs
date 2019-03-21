using Negocio;
using Negocio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebConsomeWCF.Controllers
{
    public class CotacaoController : Controller
    {
        // GET: Cotacao
        public ActionResult Index()
        {
            CotacaoViewModel model = new CotacaoViewModel();
            CarroN carroN = new CarroN();
            model.ListaCarro = carroN.ListaCarro();

            CoberturaN coberturaN = new CoberturaN();
            model.ListaCobertura = coberturaN.ListaCobertura();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CotacaoViewModel model)
        {
            var teste = model;
            ClienteN cli = new ClienteN();
            cli.SalvarCliente(model.Cliente);

            return View("ListaCotacaoCliente", cli.ListaCotacao());
        }

        public ActionResult ListaCotacaoCliente()
        {
            ClienteN cliN = new ClienteN();
            
            return View(cliN.ListaCotacao());
        }
        
    }
}
