using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProjetoSeguroWCF.TO
{
    [DataContract]
    public class Carro
    {
        [DataMember]
        public int IdCarro { get; set; }

        [DataMember]
        public string Nome { get; set; }
    }
}