using Negocio.ServiceCliente;
using Negocio.ServiceCarro;
using Negocio.ServiceCobertura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebConsomeWCF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClienteServiceClient s = new ClienteServiceClient();
            Cliente c = new Cliente() { Nome = "Ivan", CPF = "123456", Email = "ivannog@gmail.com", IdCarro = 1, IdCobertura = 4, Telefone = "11997554219" };

            s.Add(c);

            var testaCli = s.GetClienteByCpf("123456");

            CoberturaServiceClient cobertura = new CoberturaServiceClient();
            var verCobertura = cobertura.ListCoberturas();

            CarroServiceClient car = new CarroServiceClient();
            var verCarros = car.ListCar();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}