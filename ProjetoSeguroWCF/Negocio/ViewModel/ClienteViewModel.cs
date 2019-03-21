using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ViewModel
{
    public class ClienteViewModel
    {
        
        public string Nome { get; set; }

        
        public string CPF { get; set; }

        
        public string Email { get; set; }

        public string Telefone { get; set; }

        
        public string Endereco { get; set; }

        
        public string Bairro { get; set; }

        
        public string Cidade { get; set; }

        
        public string Estado { get; set; }

        
        public int IdCarro { get; set; }

        
        public CarroViewModel Carro { get; set; }

        
        public int IdCobertura { get; set; }

        
        public CoberturaViewModel Cobertura { get; set; }
    }
}
