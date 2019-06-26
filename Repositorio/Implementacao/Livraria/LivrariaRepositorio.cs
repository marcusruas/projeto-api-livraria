﻿using Dominio.Livraria;
using Repositorio.ConexaoBanco;
using Repositorio.Interface.Livraria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao.Livraria
{
    public class LivrariaRepositorio : ILivrariaRepositorio
    {
        private IConexaoBanco Conexao;
        public LivrariaRepositorio(IConexaoBanco conexao)
        {
            Conexao = conexao;
        }

        public void AtualizarAutor(Autor autor)
        {
            throw new NotImplementedException();
        }

        public void InserirNovoAutor(Autor autor)
        {
            throw new NotImplementedException();
        }
    }
}
