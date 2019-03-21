using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ViewModel
{
    public class CotacaoViewModel
    {
        public ClienteViewModel Cliente { get; set; }
       
        public List<CarroViewModel> ListaCarro { get; set; }

        public List<CoberturaViewModel> ListaCobertura { get; set; }
    }
}
