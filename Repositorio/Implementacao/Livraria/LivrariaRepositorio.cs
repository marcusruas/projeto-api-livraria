using Dominio.Livraria;
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

        public void InserirNovoAutor(Autor autor)
        {
            Conexao.Executar("inserirNovoAutor", "APPS", autor);
        }

        public void AtualizarAutor(Autor autor)
        {
            Conexao.Executar("atualizarAutor", "APPS", autor);
        }
    }
}
