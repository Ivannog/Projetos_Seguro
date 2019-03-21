using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProjetoSeguroWCF.TO
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Telefone { get; set; }

        [DataMember]
        public string Endereco { get; set; }

        [DataMember]
        public string Bairro { get; set; }

        [DataMember]
        public string Cidade { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public int IdCarro { get; set; }

        [DataMember]
        public Carro Carro { get; set; }

        [DataMember]
        public int IdCobertura { get; set; }

        [DataMember]
        public Cobertura Cobertura { get; set; }


    }
}