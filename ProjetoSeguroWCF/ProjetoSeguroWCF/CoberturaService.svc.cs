using ProjetoSeguroWCF.DAO;
using ProjetoSeguroWCF.Interfaces;
using ProjetoSeguroWCF.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProjetoSeguroWCF
{
    public class CoberturaService : ICoberturaService
    {
        public List<Cobertura> ListCoberturas()
        {
            CoberturaDAO dao = new CoberturaDAO();
            return dao.ListCoberturas();
        }
    }
}
