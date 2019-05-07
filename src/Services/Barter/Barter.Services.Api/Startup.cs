using Barter.Application.Interfaces;
using Barter.Domain.Interfaces;
using Barter.Infra.Data;
using Barter.Infra.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;
using Swashbuckle.AspNetCore.Swagger;
using User.Application.Services;

namespace Barter.Services.Api
{
    public class Startup
    {
        private Container container = new Container();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BarterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BarterConnection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Barter API", Version = "v1" });
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            RegisterDependencies();

            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));

            services.UseSimpleInjectorAspNetRequestScoping(container);
        }

        private void RegisterDependencies()
        {
            container.Register(() => { return DbHelper.GetOptions(); }, Lifestyle.Scoped);
            container.Register<DbContext>(() => { return DbHelper.GetBarterContext(); }, Lifestyle.Scoped);
            container.Register<IBarterRepository, BarterRepository>(Lifestyle.Scoped);
            container.Register<IBarterService, BarterService>(Lifestyle.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Barter API");
            });

            app.UseHttpsRedirection();
            app.UseMvc();

            container.RegisterMvcControllers(app);

            container.Verify();
        }
    }
}