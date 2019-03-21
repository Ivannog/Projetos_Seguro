using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeguroWCF.Interfaces
{
    [ServiceContract]
    public interface ICarroService
    {
        [OperationContract]
        List<Carro> ListCar();
    }
}
