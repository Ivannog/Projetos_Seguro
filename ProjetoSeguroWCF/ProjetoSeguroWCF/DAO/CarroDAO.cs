using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeguroWCF.DAO
{
    public class CarroDAO
    {
        private static List<Carro> carros = new List<Carro>();

        public List<Carro> ListCar()
        {
            CarroDAO.carros.Add(new Carro() { IdCarro = 1, Nome = "Vectra" });
            CarroDAO.carros.Add(new Carro() { IdCarro = 2, Nome = "Azera" });
            CarroDAO.carros.Add(new Carro() { IdCarro = 3, Nome = "Monza" });
            CarroDAO.carros.Add(new Carro() { IdCarro = 4, Nome = "Celta" });
            CarroDAO.carros.Add(new Carro() { IdCarro = 5, Nome = "Cruze" });
            CarroDAO.carros.Add(new Carro() { IdCarro = 6, Nome = "Gol" });

            return carros;


        }
    }
}