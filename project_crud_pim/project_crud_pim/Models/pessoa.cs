using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud_pim.Models
{
    public class pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Logradouro { get; set; }
        public int Num { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TipoTelefone { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }

    }
}