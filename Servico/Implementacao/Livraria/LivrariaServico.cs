using Dominio.Livraria;
using Repositorio.Interface.Livraria;
using Servico.Interface.Livraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Implementacao.Livraria
{
    public class LivrariaServico : ILivrariaServico
    {
        private ILivrariaRepositorio _livrariaRepositorio;
        public LivrariaServico(ILivrariaRepositorio livrariaRepositorio)
        {
            _livrariaRepositorio = livrariaRepositorio;
        }

        public void InserirNovoAutor(Autor autor)
        {
            _livrariaRepositorio.InserirNovoAutor(autor);
        }
    }
}
