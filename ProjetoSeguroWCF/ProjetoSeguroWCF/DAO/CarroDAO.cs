using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeguroWCF.DAO
{
    public class CarroDAO
    {
        public List<Carro> ListCar()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro() { IdCarro = 1, Nome = "Vectra" });
            carros.Add(new Carro() { IdCarro = 2, Nome = "Azera" });
            carros.Add(new Carro() { IdCarro = 3, Nome = "Monza" });
            carros.Add(new Carro() { IdCarro = 4, Nome = "Celta" });
            carros.Add(new Carro() { IdCarro = 5, Nome = "Cruze" });
            carros.Add(new Carro() { IdCarro = 6, Nome = "Gol" });

            return carros.Distinct().ToList();


        }
    }
}