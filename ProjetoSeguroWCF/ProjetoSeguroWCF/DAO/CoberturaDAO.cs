using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeguroWCF.DAO
{
    public class CoberturaDAO
    {
        private static List<Cobertura> listCoberturas = new List<Cobertura>();

        public List<Cobertura> ListCoberturas()
        {
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 1, Descricao = "Roubo + Incendio + Enchente" });
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 2, Descricao = "Roubo + Incendio + Enchente + Vidro" });
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 3, Descricao = "Roubo + Incendio" });
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 4, Descricao = "Roubo + Incendio + Vidro" });
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 5, Descricao = "Roubo + Incendio + Enchente + Acidente" });
            CoberturaDAO.listCoberturas.Add(new Cobertura() { IdCobertura = 6, Descricao = "Roubo + Incendio + Enchente + Acidente + Vidro" });

            return CoberturaDAO.listCoberturas;

        }
    }
}