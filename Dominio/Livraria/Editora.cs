using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio.Livraria
{
    public class Editora
    {
        [Description("IDEDITORA")]
        public Guid Id { get; set; }
        [Description("NOME")]
        public string Nome { get; set; }
        [Description("ENDERECO")]
        public string Endereco { get; set; }
        [Description("TELEFONE")]
        public string Telefone { get; set; }

    }
}
