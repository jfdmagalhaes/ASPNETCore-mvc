using Alura.ListaLeitura.App.Logica;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {        
            services.AddRouting();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);

            app.UseMvcWithDefaultRoute();

            //builder.MapRoute("{controller}/action", RoteamentoPadrao);
            //builder.MapRoute("Livros/ParaLer", LivrosLogica.ParaLer);
            //builder.MapRoute("Livros/Lendo", LivrosLogica.Lendo);
            //builder.MapRoute("Livros/Lidos", LivrosLogica.Lidos);
            //builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroLogica.NovoLivro);
            //builder.MapRoute("Livros/Detalhes/{id:int}", LivrosLogica.Detalhes);
            //builder.MapRoute("Cadastro/NovoLivro", CadastroLogica.ExibeFormulario);
            //builder.MapRoute("Cadastro/Incluir", CadastroLogica.Incluir);

            var rotas = builder.Build();
            app.UseRouter(rotas);

        }
    
    }
}