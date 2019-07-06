using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Livraria;
using Microsoft.AspNetCore.Mvc;
using Servico.Interface.Livraria;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.EndPoints.Livraria
{
    [Route("[controller]")]
    public class LivrariaController : Controller
    {
        private ILivrariaServico _livrariaServico;
        public LivrariaController(ILivrariaServico livrariaServico)
        {
            _livrariaServico = livrariaServico;
        }

        #region Endpoints Autor
        [HttpPost]
        public void InserirNovoAutor(Autor autor)
        {
            _livrariaServico.InserirNovoAutor(autor);
        }

        [HttpPut]
        public void AtualizarAutor(Autor autor)
        {
            _livrariaServico.AtualizarAutor(autor);
        }
        #endregion Endpoints Autor
    }
}
