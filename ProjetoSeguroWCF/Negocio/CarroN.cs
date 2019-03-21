using Negocio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CarroN
    {
        public List<CarroViewModel> ListaCarro()
        {
            ServiceCarro.CarroServiceClient car = new ServiceCarro.CarroServiceClient();

            var carregaCarros = car.ListCar();
            List<CarroViewModel> listaCarros = new List<CarroViewModel>();



            foreach (var item in carregaCarros)
            {
                listaCarros.Add
                    (
                        new CarroViewModel()
                        {
                            IdCarro = item.IdCarro,
                            Nome = item.Nome
                        }
                    );
            }

            return listaCarros;
        }
       

    }
}
