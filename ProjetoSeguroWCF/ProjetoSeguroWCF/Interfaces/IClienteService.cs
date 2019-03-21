using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Services;
using System.Web.UI;

namespace ProjetoSeguroWCF.Interfaces
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente c);

        [OperationContract]
        Cliente GetClienteByNome(string nome);

        [OperationContract]
        Cliente GetClienteByCpf(string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListaCotacoes")]
        List<Cliente> GetClienteCotacao();
    }
}
