using Negocio.ServiceCliente;
using Negocio.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteN
    {
        public void SalvarCliente(ClienteViewModel model)
        {
            ClienteServiceClient c = new ServiceCliente.ClienteServiceClient();

            Cliente cliente = new Cliente()
            {
                IdCarro = model.IdCarro,
                IdCobertura = model.IdCobertura,
                Nome = model.Nome,
                CPF = model.Email,
                Email = model.Email,
                Endereco = model.Endereco,
                Bairro = model.Bairro,
                Cidade = model.Cidade,
                Estado = model.Estado,
                Telefone = model.Telefone
            };

            c.Add(cliente);
        }
        public ClienteViewModel GetClienteByCpf(string cpf)
        {
            ClienteServiceClient c = new ClienteServiceClient();
            var resultado = c.GetClienteByCpf(cpf);

            return new ClienteViewModel();

        }
        public List<ClienteViewModel> ListaCotacao()
        {
            ClienteServiceClient c = new ClienteServiceClient();
            List<ClienteViewModel> listaCotacao = new List<ClienteViewModel>();

            var resultado = c.GetClienteCotacao();
            foreach(var item in resultado)
            {
                listaCotacao.Add
                    (
                        new ClienteViewModel()
                        {
                            IdCarro = item.IdCarro,
                            Carro = new CarroViewModel() { IdCarro = item.IdCarro, Nome = item.Carro.Nome },
                            IdCobertura = item.IdCobertura,
                            Cobertura = new CoberturaViewModel() { IdCobertura = item.IdCobertura, Descricao = item.Cobertura.Descricao },
                            Nome = item.Nome,
                            CPF = item.Email,
                            Email = item.Email,
                            Endereco = item.Endereco,
                            Bairro = item.Bairro,
                            Cidade = item.Cidade,
                            Estado = item.Estado,
                            Telefone = item.Telefone
                        }
                    );
            }

            return listaCotacao;
        }
    }
}
