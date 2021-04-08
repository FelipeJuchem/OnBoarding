using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OnBoarding.Data;
using OnBoarding.Data.Repositories;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using OnBoarding.Domain.Servicos;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoarding.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddDbContext<DataContext>(
                options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OnboardingA"));
            AdicionarInjecaoDeDependencia(services);
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Demo Jwt",
                    Version = "v1",
                    Description = "Projeto de demonstração ASP.Net Core"
                });
            });
            services.AddControllers();
        }

        private void AdicionarInjecaoDeDependencia(IServiceCollection services)
        {
            services.AddScoped(typeof(IEmpresaRepository), typeof(EmpresaRepository));
            services.AddScoped(typeof(IFuncionarioRepository), typeof(FuncionarioRepository));
            services.AddScoped(typeof(IArmazenadorDeEmpresa), typeof(ArmazenadorDeEmpresa));
            services.AddScoped(typeof(IExcluidorDeEmpresa), typeof(ExcluidorDeEmpresa));
            services.AddScoped(typeof(IEmpresaConsulta), typeof(EmpresaConsulta));
            services.AddScoped(typeof(IAlteradorDeEmpresa), typeof(AlteradorDeEmpresa));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo JWT Api");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
