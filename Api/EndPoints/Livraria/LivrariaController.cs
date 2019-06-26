using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


    }
}
