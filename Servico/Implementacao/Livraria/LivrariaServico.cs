using Repositorio.Interface.Livraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Implementacao.Livraria
{
    public class LivrariaServico
    {
        private ILivrariaRepositorio _livrariaRepositorio;
        public LivrariaServico(ILivrariaRepositorio livrariaRepositorio)
        {
            _livrariaRepositorio = livrariaRepositorio;
        }


    }
}
