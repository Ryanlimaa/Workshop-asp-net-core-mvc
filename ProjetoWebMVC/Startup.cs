using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProjetoWebMVC.Data;
using ProjetoWebMVC.Services;

namespace ProjetoWebMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Metodo chamado pelo runtime. Use este método para adicionar serviços ao contêiner.   
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); 
            services.Configure<CookiePolicyOptions>(options =>
            {
                // Esse lambda determina se o consentimento do usuário para cookies não essenciais é necessário para uma determinada solicitação.   
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connectionString = Configuration.GetConnectionString("ProjetoWebMVCContext");    
            services.AddDbContext<ProjetoWebMVCContext>(options =>
                    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));  
            
            services.AddScoped<SeedingService>();
            services.AddScoped<VendedorService>();
            services.AddScoped<DepartamentoService>();  
            services.AddScoped<RegistroVendaService>();
        }

        // Metodo chamado pelo runtime. Use este método para configurar o pipeline de solicitação HTTP. 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService)
        {
            // Configuração de localização para garantir que as datas sejam exibidas no formato correto 
            var enUS = new CultureInfo("en-US");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(enUS),
                SupportedCultures = new List<CultureInfo> { enUS },
                SupportedUICultures = new List<CultureInfo> { enUS }
            };

            app.UseRequestLocalization(localizationOptions);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            }); 
        }
    }
}
