using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio.Livraria
{
    public class Autor
    {
        [Description("IDAUTOR")]
        public int Id { get; set; }
        [Description("NOME")]
        public string Nome { get; set; }
        [Description("SOBRE")]
        public string Sobre { get; set; }
    }
}
