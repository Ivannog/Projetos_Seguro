using ProjetoSeguroWCF.DAO;
using ProjetoSeguroWCF.Interfaces;
using ProjetoSeguroWCF.TO;
using System.Collections.Generic;

namespace ProjetoSeguroWCF
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente c)
        {
            ClienteDAO dao = new ClienteDAO();
            dao.Add(c);
        }

        public Cliente GetClienteByNome(string nome)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.GetClienteByNome(nome);
        }

        public Cliente GetClienteByCpf(string cpf)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.GetClienteByCpf(cpf);
        }

        public List<Cliente> GetClienteCotacao()
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.GetClienteCotacao();
        }
    }
}
