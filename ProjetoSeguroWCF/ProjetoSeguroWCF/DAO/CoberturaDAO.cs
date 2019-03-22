using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeguroWCF.DAO
{
    public class CoberturaDAO
    {        
        public List<Cobertura> ListCoberturas()
        {
            List<Cobertura> listCoberturas = new List<Cobertura>();
            listCoberturas.Add(new Cobertura() { IdCobertura = 1, Descricao = "Roubo + Incendio + Enchente + Furto" , Valor = 1500.00});
            listCoberturas.Add(new Cobertura() { IdCobertura = 2, Descricao = "Roubo + Incendio + Enchente + Vidro + Furto", Valor = 3000.00 });
            listCoberturas.Add(new Cobertura() { IdCobertura = 3, Descricao = "Roubo + Incendio  + Furto", Valor = 1000.00 });
            listCoberturas.Add(new Cobertura() { IdCobertura = 4, Descricao = "Roubo + Incendio + Vidro + Furto", Valor = 1456.00 });
            listCoberturas.Add(new Cobertura() { IdCobertura = 5, Descricao = "Roubo + Incendio + Enchente + Acidente + Furto", Valor = 4000.00 });
            listCoberturas.Add(new Cobertura() { IdCobertura = 6, Descricao = "Roubo + Incendio + Enchente + Acidente + Vidro", Valor = 2000.00 });

            return listCoberturas.Distinct().ToList();

        }
    }
}