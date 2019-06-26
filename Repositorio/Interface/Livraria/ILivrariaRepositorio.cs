using Dominio.Livraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Interface.Livraria
{
    public interface ILivrariaRepositorio
    {
        #region Autor

        void InserirNovoAutor(Autor autor);
        void AtualizarAutor(Autor autor);

        #endregion Autor
    }
}
