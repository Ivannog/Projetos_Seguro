using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProjetoSeguroWCF.TO
{
    [DataContract]
    public class Cobertura
    {
        [DataMember]
        public int IdCobertura { get; set; }

        [DataMember]
        public string Descricao { get; set; }

        [DataMember]
        public double Valor { get; set; }
    }
}