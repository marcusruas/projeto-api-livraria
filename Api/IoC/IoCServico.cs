using Microsoft.Extensions.DependencyInjection;
using Servico.Implementacao;
using Servico.Implementacao.Livraria;
using Servico.Interface;
using Servico.Interface.Livraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.IoC {
    public class IoCServico {
        public static void ConfigurarServico(IServiceCollection services) {
            services.AddScoped<IStatusServico, StatusServico>();

            services.AddScoped<ILivrariaServico, LivrariaServico>();
        }
    }
}
