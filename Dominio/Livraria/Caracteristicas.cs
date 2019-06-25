using Dominio.Livraria.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio.Livraria
{
    public class Caracteristicas
    {
        [Description("IDCARACTERISTICAS")]
        public Guid Id { get; set; }
        [Description("GENERO")]
        public GeneroLivro Genero { get; set; }
        [Description("IDIOMA")]
        public IdiomaLivro Idioma { get; set; }
        [Description("ACABAMENTO")]
        public AcabamentoLivro Acabamento { get; set; }
    }
}
