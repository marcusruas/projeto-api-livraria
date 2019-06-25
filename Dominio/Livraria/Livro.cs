using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio.Livraria
{
    public class Livro
    {
        [Description("IDLIVRO")]
        public Guid Id { get; set; }
        [Description("ANO")]
        public int AnoCriacao { get; set; }
        [Description("NumPaginas")]
        public int NumeroPaginas { get; set; }
        [Description("EDICAO")]
        public int Edicao { get; set; }
        [Description("PRECO")]
        public double Valor { get; set; }
        [Description("PESO")]
        public double Peso { get; set; }
        [Description("ALTURA")]
        public double Altura { get; set; }
        [Description("IDAUTOR")]
        public Autor Autor { get; set; }
        [Description("IDEDITORA")]
        public Editora Editora { get; set; }
        [Description("IDCARACTERISTICAS")]
        public Caracteristicas Caracteristicas { get; set; }
    }
}
