using Dominio.Livraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Interface.Livraria
{
    public interface ILivrariaServico
    {
        void InserirNovoAutor(Autor autor);
        void AtualizarAutor(Autor autor);
    }
}
