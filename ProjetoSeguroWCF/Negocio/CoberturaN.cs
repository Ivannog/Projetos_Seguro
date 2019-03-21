using Negocio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CoberturaN
    {
        public List<CoberturaViewModel> ListaCobertura()
        {
            ServiceCobertura.CoberturaServiceClient cob = new ServiceCobertura.CoberturaServiceClient();

            var carregaCoberturas = cob.ListCoberturas();
            List<CoberturaViewModel> listaCoberturas = new List<CoberturaViewModel>();

            foreach (var item in carregaCoberturas)
            {
                listaCoberturas.Add
                    (
                        new CoberturaViewModel()
                        {
                            IdCobertura = item.IdCobertura,
                            Descricao = item.Descricao
                        }
                    );

            }

            return listaCoberturas;


        }
    }
}
