using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeguroWCF.DAO
{
    public class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDAO.clientes.Add(c);
        }

        public Cliente GetClienteByNome(string nome)
        {
            CarroDAO carDAO = new CarroDAO();
            CoberturaDAO cobDAO = new CoberturaDAO();
            var resultado = ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            resultado.Carro = carDAO.ListCar().Where(x => x.IdCarro == resultado.IdCarro).FirstOrDefault();
            resultado.Cobertura = cobDAO.ListCoberturas().Where(y => y.IdCobertura == resultado.IdCobertura).FirstOrDefault();
            return resultado;
        }
        public Cliente GetClienteByCpf(string cpf)
        {
            CarroDAO carDAO = new CarroDAO();
            CoberturaDAO cobDAO = new CoberturaDAO();
            var resultado = ClienteDAO.clientes.Where(c => c.CPF.Equals(cpf)).FirstOrDefault();
            resultado.Carro = carDAO.ListCar().Where(x => x.IdCarro == resultado.IdCarro).FirstOrDefault();
            resultado.Cobertura = cobDAO.ListCoberturas().Where(y => y.IdCobertura == resultado.IdCobertura).FirstOrDefault();

            return resultado;

        }
        public List<Cliente> GetClienteCotacao()
        {
            CarroDAO carDAO = new CarroDAO();
            CoberturaDAO cobDAO = new CoberturaDAO();
            foreach(var item in clientes)
            {
                item.Carro = carDAO.ListCar().Where(x => x.IdCarro == item.IdCarro).FirstOrDefault();       
                item.Cobertura = cobDAO.ListCoberturas().Where(y => y.IdCobertura == item.IdCobertura).FirstOrDefault();
            }            

            return clientes;

        }
    }
}